using prjViagem.Infrastructure.Connections;
using prjViagem.Infrastructure.Entities;
using prjViagem.Infrastructure.Interfaces;

namespace prjViagem.Infrastructure.Repositories
{
    public class RepositoryViagem : RepositoryBase<Viagem>, IRepositoryViagem
    {
        public readonly Context _context;
        public RepositoryViagem(Context Context)
            : base(Context)
        {
            _context = Context;
        }

        public virtual Viagem GetDestino(string origem_inicial,string nome_destino_final)
        {
            var result = (dynamic)null;
            try
            {
                List<dynamic> rotas = new List<dynamic>();
                rotas.Add(nome_destino_final.ToUpper());
                
                int vl_viagem = 0;
                string origem = "";
                result = _context.Set<Viagem>().Where(a => a.Destino.ToUpper().Equals(nome_destino_final.ToUpper())).OrderBy(a => a.Custo).FirstOrDefault();
                for (int i = 0; i < 10; i++)
                {
                    if (!origem.Equals(""))
                    {
                        result = _context.Set<Viagem>().Where(a => a.Destino.ToUpper().Equals(origem.ToUpper())).OrderBy(a => a.Custo).FirstOrDefault();
                    }
                    if (result.Origem.Equals(origem_inicial.ToUpper()))
                    {
                        //grava origem na lista para traçar a rota no final
                        rotas.Add(result.Origem.ToUpper() + " - ");

                        //grava a origem para utilizar como destino na proxima consulta
                        origem = result.Origem.ToUpper();

                        //soma valor na variável para custo final
                        vl_viagem += result.Custo;

                        //seta destino final e custo final calculado.
                        result.Destino = nome_destino_final.ToUpper();
                        result.Custo = vl_viagem;

                        //ordernar a rota
                        rotas.Reverse();
                        foreach (var item in rotas)
                        {
                            result.Rota += item.ToUpper();
                        }

                        return result;
                    }
                    else
                    {
                        rotas.Add(result.Origem.ToUpper() + " - ");
                        origem = result.Origem.ToUpper();
                        vl_viagem += result.Custo;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return result;
            }
            return result;
        }
    }
}
