using RacoonLogin.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacoonLogin.DAL
{
    public class LoginComand
    {
        public bool verified { get; set; }
        public string message = "";
        SqlCommand command = new SqlCommand();
        Connection connection = new Connection();
        public SqlDataReader dataReader { get; set; }


        public bool VerifyLogin(string login, string password)
        {
            //consultar o banco
            //cria o comando que será enviado para o BD
            command.CommandText = "select * from logins where login = @login and password = @password";
            //passa o valor do parâmetro pra referência do comando SQL - PARÂMETRO ---> @REFERENCIA
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                //.Connect() devolve uma conexão aberta
                command.Connection = connection.Connect();
                //usado quando o comando é de leitura (select) - dataReader recebe as informações da consulta
                dataReader = command.ExecuteReader();
                //verificar se a busca não voltou vazia
                if (dataReader.HasRows) verified = true;
                else verified = false;
                //desconectando do banco
                connection.Disconnect();
                //desativando o comando
                dataReader.Close();
            }
            catch(SqlException)
            {
                message = "ERROR!";
            }            
            return verified;
        }

        public string RegisterLogin(string login, string password, string passwordConfirmation)
        {
            verified = false;
            //cadastrar no banco
            if (password.Equals(passwordConfirmation))
            {
                command.CommandText = "insert into logins values (@login,@password);";
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    command.Connection = connection.Connect();
                    command.ExecuteNonQuery();
                    connection.Disconnect();
                    message = "Congrats!!! Now you're a racoon!";
                    verified = true;
                }
                catch (SqlException)
                {
                    message = "ERROR!";
                }
            }
            else message = "wrong passwords!";
            return message;
        }
    }
}
