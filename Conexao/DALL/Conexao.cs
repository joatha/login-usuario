﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Conexao.DALL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-RC0B7PE\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True";


        }
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}
