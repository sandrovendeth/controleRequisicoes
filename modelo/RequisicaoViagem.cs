public class RequisicaoViagem: Requisicao{
    private string? destino;
    private DateOnly? dataIda;
    private DateOnly? dataVolta;
    private double? valor;

    public string? getDestino()
    {
        return this.destino;
    }

    public void setDestino(string? destino)
    {
        this.destino = destino;
    }

    public DateOnly? getDataIda()
    {
        return this.dataIda;
    }

    public void setDataIda(DateOnly? dataIda)
    {
        this.dataIda = dataIda;
    }

    public DateOnly? getDataVolta()
    {
        return this.dataVolta;
    }

    public void setDataVolta(DateOnly? dataVolta)
    {
        this.dataVolta = dataVolta;
    }

    public double? getValor()
    {
        return this.valor;
    }

    public void setValor(double? valor)
    {
        this.valor = valor;
    }

}