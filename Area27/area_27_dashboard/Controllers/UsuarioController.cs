using area_27_dashboard.DB;
using area_27_dashboard.Models;
using Npgsql;

namespace area_27_dashboard.Controllers
{
    public class UsuarioController
    {
        public async Task<List<UsuarioViewModel>> GetAllUsuarios()
        {
            var usuarios = new List<UsuarioViewModel>();

            using (var conn = new NpgsqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM usuarios", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var usuario = new UsuarioViewModel
                        {
                            usuarioid = reader.GetInt32(reader.GetOrdinal("usuarioid")),
                            ativo = reader.GetBoolean(reader.GetOrdinal("ativo")),
                            dados = new UsuarioViewModel.Dados
                            {
                                nomecompleto = reader.GetString(reader.GetOrdinal("nomecompleto")),
                                email = reader.GetString(reader.GetOrdinal("email")),
                                cpf = reader.GetString(reader.GetOrdinal("cpf")),
                                telefone = reader.GetString(reader.GetOrdinal("telefone")),
                                senha = reader.GetString(reader.GetOrdinal("senha"))
                            },
                            permissoes = new UsuarioViewModel.PermissoesViewModel
                            {
                                pdashboard = new UsuarioViewModel.PermissoesViewModel.DashboardViewModel
                                {
                                    editdashboard = reader.GetBoolean(reader.GetOrdinal("editdashboard")),
                                    gestaodashboard = reader.GetBoolean(reader.GetOrdinal("gestaodashboard")),
                                    viewdashboard = reader.GetBoolean(reader.GetOrdinal("viewdashboard"))
                                },
                                pcadastrtos = new UsuarioViewModel.PermissoesViewModel.CadastrosViewModel
                                {
                                    categorias = reader.GetBoolean(reader.GetOrdinal("categorias")),
                                    dashboards = reader.GetBoolean(reader.GetOrdinal("dashboards")),
                                    sistema = reader.GetBoolean(reader.GetOrdinal("sistema")),
                                    usuarios = reader.GetBoolean(reader.GetOrdinal("usuarios"))
                                }
                            }
                        };
                        usuarios.Add(usuario);
                    }
                }
            }

            return usuarios;
        }

        public async Task<UsuarioViewModel> GetUsuarioById(int id)
        {
            UsuarioViewModel usuario = null;

            using (var conn = new NpgsqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM usuarios WHERE usuarioid = @id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new UsuarioViewModel
                            {
                                usuarioid = reader.GetInt32(reader.GetOrdinal("usuarioid")),
                                ativo = reader.GetBoolean(reader.GetOrdinal("ativo")),
                                dados = new UsuarioViewModel.Dados
                                {
                                    nomecompleto = reader.GetString(reader.GetOrdinal("nomecompleto")),
                                    email = reader.GetString(reader.GetOrdinal("email")),
                                    cpf = reader.GetString(reader.GetOrdinal("cpf")),
                                    telefone = reader.GetString(reader.GetOrdinal("telefone")),
                                    senha = reader.GetString(reader.GetOrdinal("senha"))
                                },
                                permissoes = new UsuarioViewModel.PermissoesViewModel
                                {
                                    pdashboard = new UsuarioViewModel.PermissoesViewModel.DashboardViewModel
                                    {
                                        editdashboard = reader.GetBoolean(reader.GetOrdinal("editdashboard")),
                                        gestaodashboard = reader.GetBoolean(reader.GetOrdinal("gestaodashboard")),
                                        viewdashboard = reader.GetBoolean(reader.GetOrdinal("viewdashboard"))
                                    },
                                    pcadastrtos = new UsuarioViewModel.PermissoesViewModel.CadastrosViewModel
                                    {
                                        categorias = reader.GetBoolean(reader.GetOrdinal("categorias")),
                                        dashboards = reader.GetBoolean(reader.GetOrdinal("dashboards")),
                                        sistema = reader.GetBoolean(reader.GetOrdinal("sistema")),
                                        usuarios = reader.GetBoolean(reader.GetOrdinal("usuarios"))
                                    }
                                }
                            };
                        }
                    }
                }
            }

            return usuario;
        }

        public async Task<bool> CreateUsuario(UsuarioViewModel usuario)
        {
            using (var conn = new NpgsqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(@"
                    INSERT INTO usuarios (ativo, nomecompleto, email, cpf, telefone, senha, editdashboard, gestaodashboard, viewdashboard, categorias, dashboards, sistema, usuarios)
                    VALUES (@ativo, @nomecompleto, @email, @cpf, @telefone, @senha, @editdashboard, @gestaodashboard, @viewdashboard, @categorias, @dashboards, @sistema, @usuarios)", conn))
                {
                    cmd.Parameters.AddWithValue("ativo", usuario.ativo);
                    cmd.Parameters.AddWithValue("nomecompleto", usuario.dados.nomecompleto);
                    cmd.Parameters.AddWithValue("email", usuario.dados.email);
                    cmd.Parameters.AddWithValue("cpf", usuario.dados.cpf);
                    cmd.Parameters.AddWithValue("telefone", usuario.dados.telefone);
                    cmd.Parameters.AddWithValue("senha", usuario.dados.senha);
                    cmd.Parameters.AddWithValue("editdashboard", usuario.permissoes.pdashboard.editdashboard);
                    cmd.Parameters.AddWithValue("gestaodashboard", usuario.permissoes.pdashboard.gestaodashboard);
                    cmd.Parameters.AddWithValue("viewdashboard", usuario.permissoes.pdashboard.viewdashboard);
                    cmd.Parameters.AddWithValue("categorias", usuario.permissoes.pcadastrtos.categorias);
                    cmd.Parameters.AddWithValue("dashboards", usuario.permissoes.pcadastrtos.dashboards);
                    cmd.Parameters.AddWithValue("sistema", usuario.permissoes.pcadastrtos.sistema);
                    cmd.Parameters.AddWithValue("usuarios", usuario.permissoes.pcadastrtos.usuarios);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public async Task<bool> UpdateUsuario(UsuarioViewModel usuario)
        {
            using (var conn = new NpgsqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(@"
                    UPDATE usuarios
                    SET ativo = @ativo, nomecompleto = @nomecompleto, email = @email, cpf = @cpf, telefone = @telefone, senha = @senha, 
                        editdashboard = @editdashboard, gestaodashboard = @gestaodashboard, viewdashboard = @viewdashboard, 
                        categorias = @categorias, dashboards = @dashboards, sistema = @sistema, usuarios = @usuarios
                    WHERE usuarioid = @usuarioid", conn))
                {
                    cmd.Parameters.AddWithValue("usuarioid", usuario.usuarioid);
                    cmd.Parameters.AddWithValue("ativo", usuario.ativo);
                    cmd.Parameters.AddWithValue("nomecompleto", usuario.dados.nomecompleto);
                    cmd.Parameters.AddWithValue("email", usuario.dados.email);
                    cmd.Parameters.AddWithValue("cpf", usuario.dados.cpf);
                    cmd.Parameters.AddWithValue("telefone", usuario.dados.telefone);
                    cmd.Parameters.AddWithValue("senha", usuario.dados.senha);
                    cmd.Parameters.AddWithValue("editdashboard", usuario.permissoes.pdashboard.editdashboard);
                    cmd.Parameters.AddWithValue("gestaodashboard", usuario.permissoes.pdashboard.gestaodashboard);
                    cmd.Parameters.AddWithValue("viewdashboard", usuario.permissoes.pdashboard.viewdashboard);
                    cmd.Parameters.AddWithValue("categorias", usuario.permissoes.pcadastrtos.categorias);
                    cmd.Parameters.AddWithValue("dashboards", usuario.permissoes.pcadastrtos.dashboards);
                    cmd.Parameters.AddWithValue("sistema", usuario.permissoes.pcadastrtos.sistema);
                    cmd.Parameters.AddWithValue("usuarios", usuario.permissoes.pcadastrtos.usuarios);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public async Task<bool> DeleteUsuario(int id)
        {
            using (var conn = new NpgsqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("DELETE FROM usuarios WHERE usuarioid = @id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
