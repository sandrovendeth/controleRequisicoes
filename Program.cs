public class Program {
    static List<Usuario> usuarios = new List<Usuario>();
    static List<Requisicao> requisicoes =  new List<Requisicao>();
    static Departamento departamento = new Departamento();
    static Departamento departamento1 = new Departamento();
    static TipoRequisicao tipoC =  new TipoRequisicao();
    static TipoRequisicao tipoV =  new TipoRequisicao();
    static TipoRequisicao tipoS =  new TipoRequisicao();

    
    public static void Main(string[] args){
       
       departamento.setDescricao("RH");
       
       departamento1.setDescricao("Financeiro");
       
       tipoC.setTipo("Compra");
       
       tipoV.setTipo("Viagem");
       
       tipoS.setTipo("Serviço");

       


       int? menu = 1;
       while(menu > 0){
        Console.WriteLine("Escolha uma opçao: 1 para cadastro de usuario 2 para cadastrar requisicao 3 para listar ou 0 para sair" );
        menu = int.Parse(Console.ReadLine());
        if(menu == 1){
            cadastrarUsuario();
        }
        if(menu == 2){
            cadastrarRequisicao();
        }
        if(menu == 3){
            listarRequisicoesPorUsuario();
        }

        Console.WriteLine("Escolha uma opçao: 1 para cadastro de usuario 2 para cadastrar requisicao ou 0 para sair" );
        menu = int.Parse(Console.ReadLine());
       }
    }

    public static void cadastrarUsuario(){
        int? qtd =1;
            Console.WriteLine("Digite o numero de usuarios que deseja cadastrar");
            qtd = int.Parse(Console.ReadLine());
            for(int i =0; i < qtd; i++){
                Usuario usuario = new Usuario();
                Console.WriteLine("Digite o nome do usuario");
                usuario.setNome(Console.ReadLine());
                 Console.WriteLine("Digite o cpf do usuario");
                usuario.setCpf(Console.ReadLine());
                Console.WriteLine("Digite a matricula do usuario");
                usuario.setMatricula(Console.ReadLine());
                usuarios.Add(usuario);
            }
    }

    public static void cadastrarRequisicao(){
        Console.WriteLine("Escolha o tipo de requisiao 1 para compra, 2 para viagem e 3 para serviço:");
        int tipo = int.Parse(Console.ReadLine());
        if(tipo == 1){
            RequisicaoCompra rc = new RequisicaoCompra();
            rc.setTipo(tipoC);
            rc.setData(new DateOnly());
            Console.WriteLine("Digite a descrição do item");
            rc.setItem(Console.ReadLine());
            Console.WriteLine("Digite o valor do item");
            rc.setValor(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a quantidade do item");
            rc.setQuantidade(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a matricula do usuario requisitante");
            string matricula = Console.ReadLine();
            for(int i = 0; i < usuarios.Count; i++){
                Usuario u = usuarios[0];
                if(u.getMatricula().Equals(matricula)){
                    rc.setRequisitante(u);
                    u.getRequisicoes().Add(rc);
                }
            }
            requisicoes.Add(rc);
        }
    }

    public static void listarRequisicoesPorUsuario(){
        usuarios.ForEach(u =>{
            Console.WriteLine("As requisiçoes do usuário " + u.getNome + " são");
            u.getRequisicoes().ForEach(r =>{
                if(r.getTipo().Equals("Compra"));
                Console.WriteLine("Tipo: " + r.getTipo().getTipo());
                Console.WriteLine("Data abertura: " + r.getData());
            });
            {
                
            }
        });
    }
}
