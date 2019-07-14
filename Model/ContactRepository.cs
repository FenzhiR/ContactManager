using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model
{
    public class ContactRepository
    {
        private List<Contact> _contactStore;
        private readonly string _stateFile;

        public ContactRepository()
        {
            _stateFile = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "ContactManager.state");
            Deserialize();
        }

        private void Deserialize()
        {
            if (File.Exists(_stateFile))
            {
                using (var stream = File.Open(_stateFile, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    _contactStore = (List<Contact>)formatter.Deserialize(stream);
                }
            }
            else
            {
                _contactStore = new List<Contact>();
            }
        }

        public void Save(Contact contact)
        {
            if(contact.Id == Guid.Empty)
            {
                contact.Id = Guid.NewGuid();
            }

            if(!_contactStore.Contains<Contact>(contact))
            {
                _contactStore.Add(contact);
            }
            Serilize();            
        }

        private void Serilize()
        {
            using(var stream = File.Open(_stateFile, FileMode.OpenOrCreate))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, _contactStore);
            }
        }

        public void Delete(Contact contact)
        {
            _contactStore.Remove(contact);
            Serilize();
        }

        public List<Contact> FindByLookup(string lookupName)
        {
            var found = _contactStore.Where(
                ct => ct.LookupName.StartsWith(lookupName, StringComparison.OrdinalIgnoreCase));
            return found.ToList<Contact>();
        }

        public List<Contact> FindAll()
        {
            return new List<Contact>(_contactStore);
        }
    }
}
