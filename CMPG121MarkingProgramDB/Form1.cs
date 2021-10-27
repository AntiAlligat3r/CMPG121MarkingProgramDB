using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace CMPG121MarkingProgramDB
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AntiAlligat3r\Documents\CMPG121_V2\CMPG121MarkingProgramDB\CMPG121MarkingProgramDB\CMPG121Students_DemiDon.mdf;Integrated Security=True");
        SqlCommand com;
        int rowIndex=0, columnIndex = 0,Marktotal;
        SqlDataAdapter adap;

        public Form1()
        {
            InitializeComponent();
        }
        
        public void loadGridView()
        {
            int rowCount = 0, _result;
            com = new SqlCommand("SELECT * FROM StudentPracMarks ORDER BY Surname", conn);
            adap = new SqlDataAdapter(com.CommandText,conn);
            DataSet _ds = new DataSet("StudentPracMarks");
            adap.Fill(_ds, "StudentPracMarks");
            dataGridView1.DataSource = _ds.Tables["StudentPracMarks"]; // Populate the datagridview

            dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[columnIndex]; //sets the previous cell location to the current cell when table refreshes

            rowCount = dataGridView1.Rows.Count; //gets total row count INCLUDING NULL row

            //traversing the datagrid matrix
            for (int _a = 3; _a < cmbxPractical.Items.Count + 3; _a++)//looping of the columns (practials)
            {
                for (int _i = 0; _i < rowCount - 1; _i++)//looping of the rows (students)
                {

                    try 
                    {
                        if (int.TryParse(dataGridView1.Rows[_i].Cells[_a].Value.ToString(), out _result))
                        {
                            if (int.Parse(dataGridView1.Rows[_i].Cells[_a].Value.ToString()) < 5 && dataGridView1.Rows[_i].Cells[_a].Value.ToString() != "")
                            {

                                dataGridView1.Rows[_i].Cells[_a].Style.BackColor = Color.Red;
                                dataGridView1.Rows[_i].Cells[_a].Style.ForeColor = Color.White;
                            }
                            else if (int.Parse(dataGridView1.Rows[_i].Cells[_a].Value.ToString()) >= 5 && int.Parse(dataGridView1.Rows[_i].Cells[_a].Value.ToString()) < 7 && dataGridView1.Rows[_i].Cells[_a].Value.ToString() != "")
                                dataGridView1.Rows[_i].Cells[_a].Style.BackColor = Color.Orange;
                            else
                                dataGridView1.Rows[_i].Cells[_a].Style.BackColor = Color.Lime;
                        }
                        
                    }
                    catch{ }
                }
            }
        }
        public void loadGridViewComments()
        {
            com = new SqlCommand("SELECT * FROM StudentPracComments ORDER BY Surname", conn);
            adap = new SqlDataAdapter(com.CommandText, conn);
            DataSet _ds = new DataSet("StudentPracComments");
            DataTable _stdPracMarks = new DataTable();
            adap.Fill(_ds, "StudentPracComments");
            dataGridView2.DataSource = _ds.Tables["StudentPracComments"];
        }

        public void loadGridViewTest()
        {
            int rowCount = 0, _result;
            com = new SqlCommand("SELECT Student_num,Name,Surname FROM StudentPracMarks ORDER BY Surname", conn);
            adap = new SqlDataAdapter(com.CommandText, conn);
            DataSet _ds = new DataSet("StudentTestMarks");
            adap.Fill(_ds, "StudentTestMarks");
            dataGridView1.DataSource = _ds.Tables["StudentTestMarks"]; // Populate the datagridview

            dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[columnIndex]; //sets the previous cell location to the current cell when table refreshes

            rowCount = dataGridView1.Rows.Count; //gets total row count INCLUDING NULL row


            //traversing the datagrid matrix
            for (int _a = 3; _a < cmbxPractical.Items.Count + 3; _a++)//looping of the columns (practials)
            {
                for (int _i = 0; _i < rowCount - 1; _i++)//looping of the rows (students)
                {

                    try
                    {
                        if (int.TryParse(dataGridView1.Rows[_i].Cells[_a].Value.ToString(), out _result))
                        {
                            if ((_result/Marktotal)*100 < 50 && dataGridView1.Rows[_i].Cells[_a].Value.ToString() != "")
                            {

                                dataGridView1.Rows[_i].Cells[_a].Style.BackColor = Color.Red;
                                dataGridView1.Rows[_i].Cells[_a].Style.ForeColor = Color.White;
                            }
                            else if ((_result / Marktotal) * 100 >= 50 && (_result / Marktotal) * 100 < 75 && dataGridView1.Rows[_i].Cells[_a].Value.ToString() != "")
                                dataGridView1.Rows[_i].Cells[_a].Style.BackColor = Color.Orange;
                            else
                                dataGridView1.Rows[_i].Cells[_a].Style.BackColor = Color.Lime;
                        }

                    }
                    catch { }
                }
            }
        }

        public void loadGridViewTestComments()
        {
            com = new SqlCommand("SELECT * FROM StudentTestComments ORDER BY Surname", conn);
            adap = new SqlDataAdapter(com.CommandText, conn);
            DataSet _ds = new DataSet("StudentPracComments");
            DataTable _stdPracMarks = new DataTable();
            adap.Fill(_ds, "StudentPracComments");
            dataGridView2.DataSource = _ds.Tables["StudentPracComments"];
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult _exit = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (_exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int _result;
            conn.Open();
            com = new SqlCommand("UPDATE StudentPracMarks SET "+cmbxPractical.Text+" = @mark WHERE Student_num = "+ dataGridView1.CurrentRow.Cells["Student_num"].Value.ToString()/*@gridStdNum"*/, conn);
            com.Parameters.AddWithValue("@mark", int.Parse(txtAdd.Text));
            adap.UpdateCommand = com;
            adap.UpdateCommand.ExecuteNonQuery();
            rowIndex = dataGridView1.CurrentCell.RowIndex;
            columnIndex = dataGridView1.CurrentRow.Cells[cmbxPractical.Text].ColumnIndex ;

            loadGridView();
            if (int.TryParse(dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString(), out _result))
            {
                if (int.Parse(txtAdd.Text) < 5 && txtAdd.Text != "")
                {

                    dataGridView1.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.Red;
                    dataGridView1.Rows[rowIndex].Cells[columnIndex].Style.ForeColor = Color.White;
                }
                else if (int.Parse(txtAdd.Text) >= 5 && int.Parse(txtAdd.Text) < 7 && txtAdd.Text != "")
                    dataGridView1.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.Orange;
                else
                    dataGridView1.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.Lime;
            }

            conn.Close();
        }
        private void btnComments_Click(object sender, EventArgs e)
        {
            CommentForm _comform = new CommentForm();
            _comform.ShowDialog();
            if (_comform.commentMethod() != "" || _comform.commentMethod() == " ")
            {
                conn.Open();
                SqlDataAdapter adap1 = new SqlDataAdapter();
                string _temp = cmbxPractical.Text + "_Comments";
                com = new SqlCommand(@"UPDATE StudentPracComments SET "+ _temp + " = @Message WHERE Student_num = " + dataGridView1.CurrentRow.Cells["Student_num"].Value.ToString(), conn);
                adap1.UpdateCommand = com;
                com.Parameters.AddWithValue("@Message", _comform.commentMethod());
                adap1.UpdateCommand.ExecuteNonQuery();
                loadGridViewComments();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Input cancelled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult _exit = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (_exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadGridViewComments();    
            com = new SqlCommand("SELECT PracName from PracList",conn);
            SqlDataReader _datRead = com.ExecuteReader();

            while (_datRead.Read())
            {
                cmbxPractical.Items.Add(_datRead.GetValue(0).ToString());
            }
            _datRead.Close();
            loadGridView();
            conn.Close();
        }

        private void addNewFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputForm _inform = new InputForm();
            _inform.ShowDialog();

            if (_inform.addField() != "" || _inform.addField() != " "|| _inform.addField() != null)
            {
                conn.Open();
                com = new SqlCommand("INSERT INTO PracList(PracName) VALUES (@new)", conn);
                adap.InsertCommand = com;
                com.Parameters.AddWithValue("@new", _inform.addField());
                adap.InsertCommand.ExecuteNonQuery();
                com = new SqlCommand("ALTER TABLE StudentPracMarks ADD " + _inform.addField() + " int NULL", conn);
                com.ExecuteNonQuery();
                com = new SqlCommand("ALTER TABLE StudentPracComments ADD " + (_inform.addField() + "_Comments") + " nvarchar(MAX) NULL", conn);
                com.ExecuteNonQuery();
                cmbxPractical.Items.Add(_inform.addField());
                loadGridView();
                loadGridViewComments();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Input cancelled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void testModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Test:";
            label4.Visible = true;
            txtTestTotal.Visible = true;
            loadGridViewTest();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblName.Text = dataGridView1.CurrentRow.Cells["Surname"].Value.ToString() + " , " + dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            
            //dataGridView2.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentRow.Cells[cmbxPractical.Text+ "_Comments"].ColumnIndex];   
        }

        
    }
}
