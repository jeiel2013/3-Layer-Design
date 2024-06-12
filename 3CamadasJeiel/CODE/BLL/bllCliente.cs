using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3CamadasJeiel.CODE.DTO;
using _3CamadasJeiel.CODE.DAL;

namespace _3CamadasJeiel.CODE.BLL
{
    internal class bllCliente
    {
        AcessoBancoDados db;

        public void inserir(dtoCliente dto)
        {
            db = new AcessoBancoDados();
            db.Conectar();
            string comando = $"call inserir_cliente('{dto.Nome}','{dto.Email}');";
            db.ExecutarComandoSQL(comando);

        }

        public void alterar(dtoCliente dto)
        {
            db = new AcessoBancoDados();
            db.Conectar();
            string comando = $"call alterar_cliente('{dto.Id_cliente}','{dto.Nome}','{dto.Email}');";
            db.ExecutarComandoSQL(comando);
        }

        public void excluir(dtoCliente dto)
        {
            db = new AcessoBancoDados();
            db.Conectar();
            string comando = $"call excluir_cliente('{dto.Id_cliente}');";
            db.ExecutarComandoSQL(comando);
        }

        public DataTable selecionar()
        {
            DataTable dt = new DataTable();
            db = new AcessoBancoDados();
            db.Conectar();
            string comando = $"call selecionar_todos_cliente();";
            dt = db.RetDataTable(comando);
            return dt;
        }

    }
}
