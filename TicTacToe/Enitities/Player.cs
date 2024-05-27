using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Enitities
{
    public class Player
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string UserName { get; set; }
        
        [Column(TypeName = "nvarchar(30)")]
        public string Password { get; set; }
        public int? WonRounds { get; set; } = 0;
    }
}
