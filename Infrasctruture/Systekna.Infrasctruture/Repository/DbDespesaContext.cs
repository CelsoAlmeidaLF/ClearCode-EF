using Systekna.Core.Model;
using Systekna.Infrasctruture.Interface;

namespace Systekna.Infrasctruture.Repository
{
    public class DbDespesaContext() 
        : DbFinanceiroContext(), IDbApplication<ModelDespesa>
    {
        public virtual ModelDespesa Add(ModelDespesa entity)
        {
            if (entity == null) return new();

            entity.DateCreated = DateTime.Now; 
            entity.DateModified = DateTime.Now;

            TbDespesa.Add(entity);
            base.SaveChanges();
            return entity;
        }
        public virtual ModelDespesa Delete(ModelDespesa entity)
        {
            var model = TbDespesa.Where(x => x.ID == entity.ID).FirstOrDefault();
            if (model == null) return new();
            model.DateModified = DateTime.Now;
            model.IsDelete = true;
            model.DateDeleted = DateTime.Now;
            base.SaveChanges();
            return model;
        }
        public virtual List<ModelDespesa> GetAll()
        {
            return TbDespesa.ToList();
        }
        public virtual ModelDespesa GetById(Guid id)
        {
            return TbDespesa.Where(x => x.ID == id).FirstOrDefault();
        }
        public virtual ModelDespesa Update(ModelDespesa entity)
        {
            var model = TbDespesa.Where(x => x.ID == entity.ID).FirstOrDefault();
            if (model == null) return new();
            model.DtVencimento = entity.DtVencimento;
            model.DsDespesa = entity.DsDespesa;
            model.VlrDespesa = entity.VlrDespesa;
            model.DateModified = DateTime.Now;
            base.SaveChanges();
            return model;
        }
    }
}