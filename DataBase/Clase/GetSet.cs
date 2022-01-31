using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Clase
{
	internal class GetSet
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Prenume { get; set; }
		public string Institutia { get; set; }
		public int Varsta { get; set; }
		public string Genul { get; set; }

		static string myconstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

		//Selectarea Datelor din baza de date
		public DataTable Select()
		{
			SqlConnection connection = new SqlConnection(myconstrng);
			DataTable dataTable = new DataTable();

			try
			{
				string sql = "SELECT * FROM studenti";
				SqlCommand command = new SqlCommand(sql, connection);
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				connection.Open();
				adapter.Fill(dataTable);
			}
			catch (Exception ex)
			{
			}
			finally
			{
				connection.Close();
			}
			return dataTable;
		}
		//Inserare data în baza de date
		public bool Insert(GetSet c)
		{
			bool issuccess = false;

			SqlConnection connection = new SqlConnection(myconstrng);
			try
			{
				string sql = "INSERT INTO studenti(nume,prenume,scoala,varsta,gen) VALUES(@nume,@prenume,@scoala,@varsta,@gen)";
				SqlCommand sqlCommand = new SqlCommand(sql, connection);
				sqlCommand.Parameters.AddWithValue("@nume",c.Name);
				sqlCommand.Parameters.AddWithValue("@prenume",c.Prenume);
				sqlCommand.Parameters.AddWithValue("@scoala", c.Institutia);
				sqlCommand.Parameters.AddWithValue("@varsta",c.Varsta);
				sqlCommand.Parameters.AddWithValue("@gen", c.Genul);

				connection.Open();
				int rand = sqlCommand.ExecuteNonQuery();
				if (rand > 0)
				{
					issuccess = true;
				}
				else
				{
					issuccess = false;
				}

			}
			catch (Exception ex)
			{ }
			finally
			{
				connection.Close();
			}
			return issuccess;
		}
		//Metoda pentru actualizare
		public bool Actulizare(GetSet c)
		{
			bool issuccess = false;
			SqlConnection conn = new SqlConnection(myconstrng);
			try
			{
				string sql = "UPDATE studenti SET nume=@nume, prenume = @prenume,scoala = @scoala,varsta=@varsta,gen=@gen WHERE id_student=@id_student";
				SqlCommand command = new SqlCommand(sql, conn);
				command.Parameters.AddWithValue("@nume", c.Name);
				command.Parameters.AddWithValue("@prenume", c.Prenume);
				command.Parameters.AddWithValue("@scoala", c.Institutia);
				command.Parameters.AddWithValue("@varsta", c.Varsta);
				command.Parameters.AddWithValue("@gen",c.Genul);
				command.Parameters.AddWithValue("@id_student", c.Id);

				conn.Open();
				int rand = command.ExecuteNonQuery();
				if (rand > 0)
				{
					issuccess=true;
				}
				else
				{
					issuccess = false;
				}
			}
			catch (Exception ex)
			{ }
			finally
			{
				conn.Close();
			}

			return issuccess;
		}
		//Metoda pentru stergere
		public bool Sterge(GetSet c)
		{
			bool issuccess=false;
			SqlConnection conn = new SqlConnection(myconstrng);
			
			try
			{
				string sql = "DELETE FROM studenti WHERE id_student=@id_student";
				SqlCommand cmd = new SqlCommand(sql, conn);	
				cmd.Parameters.AddWithValue("@id_student",c.Id);

				conn.Open();

				int rand = cmd.ExecuteNonQuery();
				if (rand > 0)
				{
					issuccess = true;
				}
				else
				{ 
					issuccess = false;
				}

			}
			catch (Exception e)
			{ }
			finally { conn.Close(); }

			return issuccess;
		}
	}
}
