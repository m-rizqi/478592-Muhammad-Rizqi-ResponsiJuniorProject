using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_2
{
    public class Karyawan
    {
        private int id;
        private string name;
        private int idDepartemen;

        public Karyawan(int id, string name, int idDepartemen)
        {
            this.id = id;
            this.name = name;
            this.idDepartemen = idDepartemen;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int IdDepartemen { get {  return idDepartemen; } set { idDepartemen = value; } }
    }
}
