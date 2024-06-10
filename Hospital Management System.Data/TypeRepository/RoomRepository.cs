using Hospital_Management_System.Domain;
using Hospital_Management_System.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Data.TypeRepository
{
    public class RoomRepository:GenericRepository<Room>,IRoomRepository
    {
        public RoomRepository(AppDbContext context):base(context)
        {
            
        }
    }
}
