using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conteudo
{
    public partial class Configuracoes : Form
    {
        BindingList<Configuracao> lista = new BindingList<Configuracao>();
        string arquivo = "eduardo.txt";
        //ignorei mesmo
        string pasta = "arquivos";
        int IdEditar { get; set; } = -1;

        public Configuracoes(int id)
        {
            IdEditar = id;
            InitializeComponent(); 
        }

        public Configuracoes():this(-1)
        { 
        }

        private  void Limpar()
        {
            data.Clear();
            informacao.Clear();
            IdEditar = -1;
        }

        private void Configuracoes_Load(object sender, EventArgs e)
        {
            LerLista();
            LoadTabela();
            LoadForm();
        }

        private void LoadTabela()
        {
            ResetTabela();
            tabela.DataSource = lista;
            CarregaBotoesTabela();
        }

        private void ResetTabela()
        {
            tabela.Columns.Clear(); 
        }

        private void CarregaBotoesTabela()
        {
            DataGridViewButtonColumn editar = new DataGridViewButtonColumn()
            { 
                Text = "Editar",
                UseColumnTextForButtonValue = true
            }; 
            tabela.Columns.Add(editar);

            DataGridViewButtonColumn excluir = new DataGridViewButtonColumn()
            { 
                Text = "Excluir",
                UseColumnTextForButtonValue = true
            };
            tabela.Columns.Add(excluir);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LerLista();
            try
            { 
                Configuracao item = GetForm();
                if(IdEditar > -1)  
                { 
                    lista[IdEditar] = item;
                }
                else 
                { 
                    lista.Add(item);
                }
                SalvarLista();  
                MessageBox.Show("Informação salva com sucesso!");
                Limpar();
                LoadTabela();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }
        
       
        private void SalvarLista()
        {
            string caminho = Path.Combine(Application.StartupPath, pasta);
            if (!Directory.Exists(caminho))
                Directory.CreateDirectory(caminho);
            caminho = Path.Combine(caminho, arquivo);
            string json = JsonConvert.SerializeObject(lista);
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(json);
            json = System.Convert.ToBase64String(plainTextBytes);
            File.WriteAllText(caminho, json);
        }


        private void LerLista()
        {
            //LENDO O ARQUIVO

            try
            {
                string caminho = Path.Combine(Application.StartupPath,pasta);
                caminho = Path.Combine(caminho, arquivo);
                if (File.Exists(caminho))
                {
                    string txt = File.ReadAllText(caminho);


                    var base64EncodedBytes = System.Convert.FromBase64String(txt);
                    txt = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);

                    lista = JsonConvert.DeserializeObject<BindingList<Configuracao>>(txt);
                }
            }
            catch { }
        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEditarAndExcluir(e.RowIndex, e.ColumnIndex);
        }

        private void tabela_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnEditarAndExcluir(tabela.CurrentCell.RowIndex, tabela.CurrentCell.ColumnIndex);
            }
        }

        private void BtnEditarAndExcluir(int linha, int coluna)
        {
            int id = Convert.ToInt32(tabela.Rows[linha].Cells[0].Value.ToString());
            if (coluna == 3) // editar
            {
                SetForm(id);
            }
            else if(coluna == 4)// excluir
            {
                if (MessageBox.Show("Deseja mesmo excluir?","Atenção",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lista.RemoveAt(id);
                    for(int x = 0; x < lista.Count; x++)
                    {
                        lista[x].Id = x;
                    }
                    SalvarLista();
                    LerLista();
                    LoadTabela();
                }
            }
        }

        private void LoadForm()
        {
            if(IdEditar > -1)
            {
                SetForm(IdEditar);
            }
        }

        private void SetForm(int id)
        {
            IdEditar = lista[id].Id;
            data.Text = lista[id].Data.ToString("dd/MM/yyyy");
            informacao.Text = lista[id].informacao;
        }

        private Configuracao GetForm()
        {
            Configuracao item = new Configuracao();

            try
            {
                item.Data = DateTime.Parse(data.Text);
            }
            catch
            {

                item.Data = default(DateTime);
            }
            item.informacao = informacao.Text;

            if (IdEditar > -1) //editando
            {
                item.Id = IdEditar; 
            }
            else //novo
            {
                item.Id = lista.Count; 
            }

            return item;
        }
    }
}
