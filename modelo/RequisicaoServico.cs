public class RequisicaoServico: Requisicao {
    private string? descricao;
    private string? urgencia;

    public string? getDescricao()
    {
        return this.descricao;
    }

    public void setDescricao(string? descricao)
    {
        this.descricao = descricao;
    }

    public string? getUrgencia()
    {
        return this.urgencia;
    }

    public void setUrgencia(string? urgencia)
    {
        this.urgencia = urgencia;
    }

}