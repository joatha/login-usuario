using Conexao.DALL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conexao.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (loginDao.mensagem != null)
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;

        }
        public String cadastrar(String email, String senha, String confSenha)
        {
            return mensagem;
        }
    }
}
