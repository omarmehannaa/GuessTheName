using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class LobbyRoomInfo
    {
            public Guid RoomId { get; set; }
            public string Category { get; set; }
            public bool IsGameAcceptOpponent { get; set; }
    }
}
