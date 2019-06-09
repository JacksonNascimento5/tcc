using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TCCEsportivo.Models;

namespace TCCEsportivo.Data
{
    public class DAO
    {
        
        public void CadastrarCliente(DTO ag)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbCliente values(null,@nome,@cpf,@email,@tel,@datanasc,@gene)", con.MyConectarBD());

            
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = ag.NomeCli;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = ag.CpfCli;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = ag.EmailCli;
            cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = ag.TelCli;
            cmd.Parameters.Add("@datanasc", MySqlDbType.VarChar).Value = ag.DataCli;
            cmd.Parameters.Add("@gene", MySqlDbType.VarChar).Value = ag.GeneCli;

            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public void CadastrarFuncionario(DTO ag)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbFuncionario values(null,@nome,@cpf,@tel,@datacontra,@cargo)", con.MyConectarBD());

            cmd.Parameters.Add("@cod", MySqlDbType.VarChar).Value = ag.CodFunc1;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = ag.NomeFunc1;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = ag.CpfFunc1;
            cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = ag.TelFunc1;
            cmd.Parameters.Add("@datacontra", MySqlDbType.VarChar).Value = ag.DTFunc1;
            cmd.Parameters.Add("@cargo", MySqlDbType.VarChar).Value = ag.CarFunc1;

            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }


        public void CadastraEndCli(DTO ag)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbEndereco values(@cep,@logradouro,@bairro,@cidade,@numcasa,@complemento,@codcli)", con.MyConectarBD());

            
        }

        Conexao con = new Conexao();
        public void InserirCli(DTO dto)
        {
            MySqlCommand cmd = new MySqlCommand("inserirCliente", con.MyConectarBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@varCodCli", MySqlDbType.VarChar).Value = dto.CodCli;
            cmd.Parameters.Add("@varNomeCli", MySqlDbType.VarChar).Value = dto.NomeCli;
            cmd.Parameters.Add("@varCpfCli", MySqlDbType.VarChar).Value = dto.CpfCli;
            cmd.Parameters.Add("@varEmailCli", MySqlDbType.VarChar).Value = dto.EmailCli;
            cmd.Parameters.Add("@varTelCli", MySqlDbType.VarChar).Value = dto.TelCli;
            cmd.Parameters.Add("@varData", MySqlDbType.VarChar).Value = dto.DataCli;
            cmd.Parameters.Add("@varGene", MySqlDbType.VarChar).Value = dto.GeneCli;
            
            
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public void InserirFunc(DTO dto)
        {
            MySqlCommand cmd = new MySqlCommand("inserirFuncionario", con.MyConectarBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@varCodFunc", MySqlDbType.VarChar).Value = dto.CodFunc1;
            cmd.Parameters.Add("@varNomeFunc", MySqlDbType.VarChar).Value = dto.NomeFunc1;
            cmd.Parameters.Add("@varCpfFunc", MySqlDbType.VarChar).Value = dto.CpfFunc1;
            cmd.Parameters.Add("@varTelFunc", MySqlDbType.VarChar).Value = dto.TelFunc1;
            cmd.Parameters.Add("@varDTContrat", MySqlDbType.VarChar).Value = dto.DTFunc1;
            cmd.Parameters.Add("@varCargo", MySqlDbType.VarChar).Value = dto.CarFunc1;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public void InserirEndereco(DTO dto)
        {
            MySqlCommand cmd = new MySqlCommand("inserirEndereco", con.MyConectarBD());
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }
    }
}