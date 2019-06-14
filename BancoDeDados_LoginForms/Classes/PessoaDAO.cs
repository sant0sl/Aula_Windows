using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeDados_LoginForms.Forms;
using BancoDeDados_LoginForms.Classes;
using BancoDeDados_LoginForms.EDM;

namespace BancoDeDados_LoginForms.Classes
{
    public class PessoaDAO
    {

        public static string cadastrarPessoa(pessoa p)
        {
            using (LoginEntities entities = new LoginEntities())
            {
                try
                {
                    pessoa createPessoa = new pessoa();

                    bool cpfaux = false;
                    bool nomeaux = false;
                    bool sobrenomeaux = false;
                    bool emailaux = false;
                    bool idadeaux = false;
                    bool sexoaux = false;
                    bool senhaaux = false;
                    
                    if (p.cpf.Equals(null) || p.cpf.Equals("") || p.cpf.Length < 11)
                    {
                        cpfaux = false;
                    }
                    else
                    {
                        createPessoa.cpf = p.cpf;
                        cpfaux = true;
                    }

                    if (p.nome.Equals(null) || p.nome.Equals(""))
                    {
                        nomeaux = false;
                    }
                    else
                    {
                        createPessoa.nome = p.nome;
                        nomeaux = true;
                    }

                    if (p.sobrenome.Equals(null) || p.sobrenome.Equals(""))
                    {
                        sobrenomeaux = false;
                    }
                    else
                    {
                        createPessoa.sobrenome = p.sobrenome;
                        sobrenomeaux = true;
                    }

                    if (p.email.Equals(null) || p.email.Equals(""))
                    {
                        emailaux = true;
                    }
                    else
                    {
                        createPessoa.email = p.email;
                        emailaux = true;
                    }

                    if (p.idade.Equals(null) || p.idade.Equals(""))
                    {
                        idadeaux = false;
                    }
                    else
                    {
                        createPessoa.idade = p.idade;
                        idadeaux = true;
                    }

                    if (p.sexo.Equals(null) || p.sexo.Equals(""))
                    {
                        sexoaux = false;
                    }
                    else
                    {
                        createPessoa.sexo = p.sexo;
                        sexoaux = true;
                    }

                    if (p.senha.Equals(null) || p.senha.Equals(""))
                    {
                        senhaaux = false;
                    }
                    else
                    {
                        createPessoa.senha = p.senha;
                        senhaaux = true;
                    }


                    if (cpfaux == true && nomeaux == true && sobrenomeaux == true && emailaux == true && idadeaux == true && sexoaux == true && senhaaux == true)
                    {
                        entities.pessoas.Add(createPessoa);
                        entities.SaveChanges();
                        return "Cadastro realizado com sucesso!";
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception e)
                {
                    return "Erro: "+e.Message;
                }
            }
        }

        public static string alterarPessoa(pessoa p)
        {
            using (LoginEntities entities = new LoginEntities())
            {
                try
                {
                    pessoa updatePessoa = new pessoa();
                    updatePessoa = entities.pessoas.FirstOrDefault(up => up.cpf == p.cpf);

                    if (p.nome.Equals(null) || p.nome.Equals(""))
                    {
                        updatePessoa.nome = updatePessoa.nome;
                    }
                    else
                    {
                        updatePessoa.nome = p.nome;
                    }

                    if (p.sobrenome.Equals(null) || p.sobrenome.Equals(""))
                    {
                        updatePessoa.sobrenome = updatePessoa.sobrenome;
                    }
                    else
                    {
                        updatePessoa.sobrenome = p.sobrenome;
                    }

                    if (p.email.Equals(null) || p.email.Equals(""))
                    {
                        updatePessoa.email = updatePessoa.email;
                    }
                    else
                    {
                        updatePessoa.email = p.email;
                    }

                    if (p.idade.Equals(null) || p.idade.Equals(""))
                    {
                        updatePessoa.idade = updatePessoa.idade;
                    }
                    else
                    {
                        updatePessoa.idade = p.idade;
                    }

                    if (p.sexo.Equals(null) || p.sexo.Equals(""))
                    {
                        updatePessoa.sexo = updatePessoa.sexo;
                    }
                    else
                    {
                        updatePessoa.sexo = p.sexo;
                    }

                    if (p.senha.Equals(null) || p.senha.Equals(""))
                    {
                        updatePessoa.senha = updatePessoa.senha;
                    }
                    else
                    {
                        updatePessoa.senha = p.senha;
                    }

                    entities.SaveChanges();
                    return "Dados do Cadastro foram atualizados com sucesso!";
                }
                catch (Exception e)
                {
                    return "Erro: " + e.Message;
                }
            }
        }
        
        public static string deletarPessoa(pessoa p)
        {
            using (LoginEntities entities = new LoginEntities())
            {
                try
                {
                    pessoa deletePessoa = new pessoa();
                    deletePessoa = entities.pessoas.FirstOrDefault(del => del.cpf == p.cpf);

                    if (deletePessoa == null || deletePessoa.cpf.Equals(null) || deletePessoa.cpf.Equals(""))
                    {
                        return "Operação não realizada.\nNão foi encontrado ninguém com este CPF na base de dados!";
                    }
                    else
                    {
                        entities.pessoas.Remove(deletePessoa);
                        entities.SaveChanges();
                        return "Operação realizada com sucesso!\nSua conta foi apagada da base de dados.";
                    }
                }
                catch (Exception e)
                {
                    return "Erro: " + e.Message;
                }
            }
        }

        public static pessoa verificarLogin(string cpf, string senha)
        {
            using (LoginEntities entities = new LoginEntities())
            {
                try
                {
                    pessoa pessoaLogada = new pessoa();
                    pessoaLogada = entities.pessoas.SqlQuery("select * from pessoa where cpf='" + cpf + "' and senha='" + senha + "'").Single();

                    if (pessoaLogada == null || pessoaLogada.cpf.Equals(null) || pessoaLogada.cpf.Equals(""))
                    {
                        return null;

                    }
                    else
                    {
                        return pessoaLogada;
                    }
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public static pessoa buscarPessoa(string cpf)
        {
            using (LoginEntities entities = new LoginEntities())
            {
                try
                {
                    pessoa pessoaEncontrada = new pessoa();
                    pessoaEncontrada = entities.pessoas.FirstOrDefault(find => find.cpf == cpf);
                    return pessoaEncontrada;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

    }
}
