using Systekna.Application.Business;
using Systekna.Core.Model;

namespace TestApplication
{
    public class TestsBbDespesa
    {
        public BbDespesaContext Bb { get; private set; }

        [SetUp]
        public void Setup() => Bb = new BbDespesaContext();

        [Test]
        public void TestAddDespesa()
        {
            var mod = Bb.Add(
                new ModelDespesa() { 
                    DsDespesa = "minha despesas", 
                    VlrDespesa = 100.00, 
                    DtVencimento = new DateTime(
                        DateTime.Now.Year, 
                        DateTime.Now.Month, 10)
            });

            if (mod == null) Assert.IsNull(mod);
            Guid id = mod != null ? mod.ID : new Guid();
            var ent = Bb.GetById(id);
            Assert.IsNotNull(ent); 
        }

        [Test]
        public void TestUpdateDespesa()
        {
            var mod = Bb.Update(
                    new ModelDespesa()
                    {

                        ID = new Guid("2DBA85AD-E4C7-420A-96BB-8C90B0DF9D15"),
                        DsDespesa = "minha despesas",
                        VlrDespesa = 100.00,
                        DtVencimento = new DateTime(
                                            DateTime.Now.Year,
                                            DateTime.Now.Month, 10)
                                                });

            if (mod == null) Assert.IsNull(mod);
            Guid id = mod != null ? mod.ID : new Guid();
            var ent = Bb.GetById(id);
            Assert.IsNotNull(ent);
        }

        [Test]
        public void TestDeleteDespesa()
        {
            var mod = Bb.Delete(
                new ModelDespesa()
                    {

                        ID = new Guid("2DBA85AD-E4C7-420A-96BB-8C90B0DF9D15"),
                        DsDespesa = "minha despesas",
                        VlrDespesa = 100.00,
                        DtVencimento = new DateTime(
                                            DateTime.Now.Year,
                                            DateTime.Now.Month, 10)
                    });

            if (mod == null) Assert.IsNull(mod);
            Guid id = mod != null ? mod.ID : new Guid();
            var ent = Bb.GetById(id);
            Assert.IsNotNull(ent);
        }

        [Test]
        public void TestGetAllDespesa()
        {
            var list = Bb.GetAll();
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }
    }
}