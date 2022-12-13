using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Final_CNPM_Winform
{
    public partial class MainForm : Form
    {
        String strConn = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;
        public MainForm()
        {
            InitializeComponent();
            ReloadAgent();
            ReloadExport();
            ReloadImport();
            ReloadProduct();
            ReloadPayment();
        }


        /// <summary>
        /// Load Tables
        /// </summary>
        public void ReloadProduct()
        {
            SqlConnection conn=new SqlConnection(strConn);
            conn.Open();
            String sql = "SELECT * FROM PRODUCT";
            SqlCommand command=new SqlCommand(sql, conn);
            SqlDataAdapter dataAdapter=new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                dtgProduct.DataSource = dt;
                dtgProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgProduct.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        public void ReloadAgent()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sql = "SELECT * FROM AGENT";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dtgAgent.DataSource = dt;
                dtgAgent.Columns[1].AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
                dtgAgent.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgAgent.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgAgent.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgAgent.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        public void ReloadPayment()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sql = "SELECT * FROM PAYMENT_METHOD";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dtgPayment.DataSource = dt;
                dtgPayment.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgPayment.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        public void ReloadImport()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sql = "SELECT * FROM IMPORT_ORDER";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dtgImport.DataSource = dt;
                dtgImport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgImport.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgImport.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgImport.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        public void ReloadExport()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            String sql = "SELECT * FROM EXPORT_ORDER";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dtgExport.DataSource = dt;
                dtgExport.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgExport.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgExport.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgExport.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        /// <summary>
        /// Insert to database
        /// </summary>
        
        private bool InsertProduct(String id, String name, int price)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(strConn);
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO PRODUCT VALUES(@id, @name,@price)";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@price", price);
                command.ExecuteNonQuery();
                result=true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        private bool InsertAgent(String id,String name,String email,String address,String phone)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(strConn);
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO AGENT VALUES(@id, @name,@email,@address,@phone)";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@phone", phone);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        private bool InsertPayment(String id, String name)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(strConn);
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO PAYMENT_METHOD VALUES(@id, @name)";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);               
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }



        ///
        /// Delete from database
        ///
        private bool DeleteProduct(String id)
        {
            bool result=false;
            SqlConnection conn=new SqlConnection(strConn);
            try{
                conn.Open();
                SqlCommand command=conn.CreateCommand();
                command.CommandText = "DELETE FROM PRODUCT WHERE PRODUCT_ID = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                result= true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        private bool DeleteAgent(String id)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(strConn);
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "DELETE FROM AGENT WHERE AGENT_ID = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        private bool DeletePayment(String id)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(strConn);
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "DELETE FROM PAYMENT_METHOD WHERE PAYMENT_ID = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot delete this method because it is in use");
            }
            finally
            {
                conn.Close();
            }
            return result;
        }








        /// <summary>
        /// Button click events
        /// </summary>

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int price;
            if (txtID.Text.Equals("") || txtID.Text.Length >5)
            {
                MessageBox.Show("Invalid ID");
            }else if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Please enter product name");
            }else if (!Int32.TryParse(txtPrice.Text,out price))
            {   
                MessageBox.Show("Empty or invalid price");
            }
            else
            {
                if (InsertProduct(txtID.Text,txtName.Text,price))
                {
                    MessageBox.Show("Success!!!");
                    ReloadProduct();
                }
                else
                {
                    MessageBox.Show("Add fail ");
                }
            }
        }

        private void dtgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0&&e.ColumnIndex==colDelete.Index)
            {
                DialogResult dialog = MessageBox.Show("Do you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    String id =dtgProduct.Rows[e.RowIndex].Cells["ProId"].Value.ToString();
                    
                   if (DeleteProduct(id))
                    {
                        MessageBox.Show("Product Deleted");
                        ReloadProduct();
                    }
                    else
                    {
                        MessageBox.Show("Delete Fail");
                        ReloadProduct();
                    }
                }
            }
        }

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            if (txtAgentId.Text.Equals("")&&txtAgentName.Text.Equals("")&& txtAgentEmail.Text.Equals("") &&txtAgentAddress.Text.Equals("") &&txtAgentPhone.Text.Equals(""))
            {
                MessageBox.Show("You must enter all informations");
            }else if (txtAgentId.Text.Length>5)
            {
                MessageBox.Show("Invalid ID");
            }else if (!checkPhone(txtAgentPhone.Text.ToString()))
            {
                MessageBox.Show("Invalid phone");
            }
            else
            {
                if (InsertAgent(txtAgentId.Text, txtAgentName.Text, txtAgentEmail.Text, txtAgentAddress.Text, txtAgentPhone.Text))
                {
                    MessageBox.Show("Success");
                    ReloadAgent();
                }
                else
                {
                    MessageBox.Show("Add fail");
                    ReloadAgent();
                }
            }
        }
        private bool checkPhone(String phone)
        {
            int item;
            bool result = true;
            foreach(Char i in phone)
            {
                if (!int.TryParse(i.ToString(),out item))
                {
                    result= false;
                }
            }
            return result;
        }

        private void dtgAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == colDelete.Index)
            {
                DialogResult dialog = MessageBox.Show("Do you want to delete this Agent?", "Confirm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    String id = dtgAgent.Rows[e.RowIndex].Cells["ColId"].Value.ToString();

                    if (DeleteAgent(id))
                    {
                        MessageBox.Show("Agent Deleted");
                        ReloadAgent();
                    }
                    else
                    {
                        MessageBox.Show("Delete Fail");
                        ReloadAgent();
                    }
                }
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            if (txtPaymentId.Text.Equals("") || txtPaymentId.Text.Length > 5)
            {
                MessageBox.Show("Invalid id");
            }else if(txtPaymentName.Text.Equals("")){
                MessageBox.Show("Invalid name");
            }
            else
            {
                if (InsertPayment(txtPaymentId.Text.ToString(), txtPaymentName.Text.ToString()))
                {
                    MessageBox.Show("Success");
                    ReloadPayment();
                }
                else
                {
                    MessageBox.Show("Insert fail");
                    ReloadPayment();
                }
            }
        }

        private void dtgPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == colPayDel.Index)
            {
                DialogResult dialog = MessageBox.Show("Do you want to delete this Payment method ?", "Confirm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    String id = dtgPayment.Rows[e.RowIndex].Cells["ColPayId"].Value.ToString();

                    if (DeletePayment(id))
                    {
                        MessageBox.Show("Payment method Deleted");
                        ReloadPayment();
                    }
                    else
                    {
                        MessageBox.Show("Delete Fail");
                        ReloadPayment();
                    }
                }
            }
        }
    }
}
