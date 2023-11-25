namespace Systekna.Core
{
    public interface IData<TEntity>
    {
        List<TEntity> GetAll();
        TEntity GetById(Guid id);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
    }
}