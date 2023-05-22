public class RequisicaoCompra: Requisicao {
    private string? item;
    private double? valor;
    private int? quantidade;

    public string? getItem()
    {
        return this.item;
    }

    public void setItem(string? item)
    {
        this.item = item;
    }

    public double? getValor()
    {
        return this.valor;
    }

    public void setValor(double? valor)
    {
        this.valor = valor;
    }

    public int? getQuantidade()
    {
        return this.quantidade;
    }

    public void setQuantidade(int? quantidade)
    {
        this.quantidade = quantidade;
    }

}