using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Conexao.DALL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            //comando sql para verificar se (tem) no banco
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) //se foi encontrado
                {
                    tem = true;

                }
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;

        }
        public String cadastrar (String email, String senha, String confSenha)
        {
            //comando para inserir no banco

            return mensagem;

        }
    }
}
