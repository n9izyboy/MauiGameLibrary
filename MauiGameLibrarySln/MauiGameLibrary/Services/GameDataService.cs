using MauiGameLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGameLibrary.Services
{
    public class GameDataService
    {
        private List<GameInfo> _gameInfo = new List<GameInfo>();

        public List<GameInfo> GetAllGameInfo()
        {
            return _gameInfo;    
                
        }

        public void UpdateGameInfo(GameInfo gameInfo)
        {
            if (!string.IsNullOrEmpty(gameInfo.Id))
            {

                var uniqueGame = GetGameInfoById(gameInfo.Id);

                int position = _gameInfo.IndexOf(uniqueGame);

                _gameInfo[position] = gameInfo;
            }
            else
            {
                _gameInfo.Add(gameInfo);
            }

        }
        public GameInfo GetGameInfoById(string id)
        {
            var uniqueGame = _gameInfo.Where(gameInfo => gameInfo.Id == id).FirstOrDefault();
            return uniqueGame;
        }
        

        public List <GameInfo> GetGameInfoByTitle (string title)
        {
           return _gameInfo.Where(gameInfo => gameInfo.Title == title).ToList();

        }
    }
}
