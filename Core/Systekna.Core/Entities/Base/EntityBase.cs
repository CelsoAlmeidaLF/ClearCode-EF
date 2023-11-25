using System.ComponentModel.DataAnnotations;

namespace Systekna.Core.Entities.Base
{
    public abstract class EntityBase
    {
        private Guid? _uid = null!;
        private DateTime? _dateCreated = null!;
        private DateTime? _dateModified = null!;
        private bool _isDelete = false;
        private DateTime? _dateDeleted = null!;

        [Key]
        public virtual Guid ID { 
            get { return _uid == null ? new Guid() : (Guid)_uid; } 
            set {  _uid = value; } 
        }

        public DateTime? DateCreated { get { return _dateCreated; } set { _dateCreated = value; } }
        public DateTime? DateModified { get { return _dateModified; } set { _dateModified = value; } }
        public bool IsDelete { get { return _isDelete; } set { _isDelete = value; } }
        public DateTime? DateDeleted { get { return _dateDeleted; } set { _dateDeleted = value; } }
    }
}
