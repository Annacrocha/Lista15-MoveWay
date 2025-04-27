namespace MoveWay_Lista15
{
    public partial class MoveWay : Form
    {
        public MoveWay()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtID.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    Setores setor = new Setores();
                    setor.Id = Convert.ToInt32(txtID.Text);
                    setor.Nome = txtNome.Text;
                    if (setor.InserirSetor())
                    {
                        MessageBox.Show("Setor inserido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir dados");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir setor: " + ex.Message);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtID.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    Setores setor = new Setores();
                    setor.Id = Convert.ToInt32(txtID.Text);
                    setor.Nome = txtNome.Text;
                    if (setor.AtualizarSetor())
                    {
                        MessageBox.Show("Setor editado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao editar dados");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar setor: " + ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtID.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    Setores setor = new Setores();
                    setor.Id = Convert.ToInt32(txtID.Text);
                    setor.Nome = txtNome.Text;
                    if (setor.ExcluirSetor())
                    {
                        MessageBox.Show("Setor excluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir dados");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir setor: " + ex.Message);
            }
        }

        private void btListar_Click(object sender, EventArgs e)
        {

            List<Setores> setores = new Setores().ListarSetores();

            if (setores != null && setores.Count > 0)
            {
              
                dataGridView1.DataSource = setores;
            }
            else
            {
                MessageBox.Show("Nenhum setor encontrado.");
            }

            txtID.Clear();
            txtNome.Clear();
            txtID.Focus();
        }
    }
}





