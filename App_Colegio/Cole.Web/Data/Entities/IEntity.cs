namespace Cole.Web.Data.Entities
{
    public interface IEntity
    {
        //El Id es un atributo: Esto hace que todo lo relacionado con Entity, debe de tener al atributo como obligatorio
        int Id { get; set; }
    }
}
