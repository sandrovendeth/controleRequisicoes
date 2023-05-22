public class Requisicao{
    private DateOnly? data;
    private Usuario? requisitante;
    private Usuario? responsavel;
    private TipoRequisicao? tipo;

   
    public DateOnly? getData()
    {
        return this.data;
    }

    public void setData(DateOnly? data)
    {
        this.data = data;
    }

    public Usuario? getRequisitante()
    {
        return this.requisitante;
    }

    public void setRequisitante(Usuario? requisitante)
    {
        this.requisitante = requisitante;
    }

    public Usuario? getResponsavel()
    {
        return this.responsavel;
    }

    public void setResponsavel(Usuario? responsavel)
    {
        this.responsavel = responsavel;
    }

     public TipoRequisicao? getTipo()
    {
        return this.tipo;
    }

    public void setTipo(TipoRequisicao? tipo)
    {
        this.tipo = tipo;
    }

}