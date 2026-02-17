using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person2
{
    public interface IDataSourceOperations
    {
        void Insert(StudentDto studentDto);
        void Delete(int id);
        void Update(StudentDto studentDto);
        OperationResult<DataTable> Select(string search);

    }
}
