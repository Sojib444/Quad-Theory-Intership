using Internship.Infrastructure.Repository.EntityRepoository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Infrastructure.UnitOfWork
{
	public interface IApplicationUnitofWork:IUnitofWork
	{
		 IStudentrepository Studentrepository { get; set; }
		 IClassTebleRepository ClassTebleRepository { get; set; }
	}
}
