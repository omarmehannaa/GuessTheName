using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Responses
{
    public class GoToLobby
    {
        Dictionary<Guid, LobbyRoomInfo> Rooms { get; set; } = new();
    }
}
