using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase.Clase;

namespace DataBase
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		GetSet c = new GetSet();

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

	

		private void btnAdd_Click(object sender, EventArgs e)
		{
			c.Name = txtboxNume.Text;
			c.Prenume = txtboxPrenume.Text;
			c.Institutia = txtboxStudii.Text;
			c.Varsta = int.Parse(txtboxVarsta.Text);
			c.Genul = cmbGen.Text;
			
			bool success = c.Insert(c);
			if (success == true)
			{
				
				MessageBox.Show("Inserat cu succes !!!");
				clear();
			}
			else
			{
				MessageBox.Show("Eroarea la adaugarea unui nou contact ???");
			}
			DataTable dt = c.Select();
			dgvDate.DataSource = dt;

		}

		private void PrintData(object sender, EventArgs e)
		{
			DataTable dt = c.Select();
			dgvDate.DataSource = dt;
		}


		public void clear()
		{
			txtboxID.Text = "";
			txtboxNume.Text = "";
			txtboxPrenume.Text = "";
			txtboxStudii.Text = "";
			txtboxVarsta.Text = "";
			cmbGen.Text = "";
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			c.Id = int.Parse(txtboxID.Text);
			c.Name = txtboxNume.Text;
			c.Prenume = txtboxPrenume.Text;
			c.Institutia = txtboxStudii.Text;
			c.Varsta = int.Parse(txtboxVarsta.Text);
			c.Genul = cmbGen.Text;
			bool success = c.Actulizare(c);
			if (success == true)
			{
				MessageBox.Show("Actualizare cu succes!!!");
				DataTable dt = c.Select();
				dgvDate.DataSource = dt;
				clear();
			}
			else
			{
				MessageBox.Show("Eroarea la actualizare???");
			}
		}


		private void dgvDate_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int rowIndex = e.RowIndex;
			txtboxID.Text = dgvDate.Rows[rowIndex].Cells[0].Value.ToString();
			txtboxNume.Text = dgvDate.Rows[rowIndex].Cells[1].Value.ToString();
			txtboxPrenume.Text = dgvDate.Rows[rowIndex].Cells[2].Value.ToString();
			txtboxStudii.Text = dgvDate.Rows[rowIndex].Cells[3].Value.ToString();
			txtboxVarsta.Text = dgvDate.Rows[rowIndex].Cells[4].Value.ToString();
			cmbGen.Text = dgvDate.Rows[rowIndex].Cells[5].Value.ToString();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			clear();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			c.Id = Convert.ToInt32(txtboxID.Text);
			bool success = c.Sterge(c);
			if (success == true)
			{
				MessageBox.Show("Șters cu succes!!!");
				DataTable dt = c.Select();
				dgvDate.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Eroarea la ștergere???");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'studentiDataSet1.studenti' table. You can move, or remove it, as needed.
			this.studentiTableAdapter.Fill(this.studentiDataSet1.studenti);

		}
	}
}
