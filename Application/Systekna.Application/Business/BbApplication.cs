using Systekna.Application.Business.Interface;
using Systekna.Core.Model;
using Systekna.Infrasctruture.Repository;

namespace Systekna.Application.Business
{
    public class BbDespesaContext()
                : DbDespesaContext(), IBbApplication<ModelDespesa>
    {
    }
}
