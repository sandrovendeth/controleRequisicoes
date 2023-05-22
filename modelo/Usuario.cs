public class Usuario{
    private string? nome;
    private string? cpf;
    private string? matricula;
    private Departamento? departamento;

    private List<Requisicao>? requisicoes = new List<Requisicao>();

    public string? getNome()
    {
        return this.nome;
    }

    public void setNome(string? nome)
    {
        this.nome = nome;
    }

    public string? getCpf()
    {
        return this.cpf;
    }

    public void setCpf(string? cpf)
    {
        this.cpf = cpf;
    }

    public string? getMatricula()
    {
        return this.matricula;
    }

    public void setMatricula(string? matricula)
    {
        this.matricula = matricula;
    }

    public Departamento? getDepartamento()
    {
        return this.departamento;
    }

    public void setDepartamento(Departamento? departamento)
    {
        this.departamento = departamento;
    }

    public List<Requisicao>? getRequisicoes()
    {
        return this.requisicoes;
    }

    public void setRequisicoes(List<Requisicao>? requisicoes)
    {
        this.requisicoes = requisicoes;
    }

    public Usuario(){}
}