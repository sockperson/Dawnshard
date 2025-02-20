﻿using DragaliaAPI.Models.Generated;
using DragaliaAPI.Photon.Shared.Models;

namespace DragaliaAPI.Services.Photon;

public interface IMatchingService
{
    Task<bool> GetIsHost();
    Task<MatchingGetRoomNameData?> GetRoomById(int id);
    Task<IEnumerable<RoomList>> GetRoomList();
    Task<IEnumerable<RoomList>> GetRoomList(int questId);
    Task<IEnumerable<Player>> GetTeammates();
}
