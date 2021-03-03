using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nettbutikk
{
    class MusicStore
    {
        private readonly Sections _sections;
        private HandleCommand _handleCommand;

        public MusicStore()
        {
            _sections = new Sections();
        }

        public void HandleSelection()
        {
            _handleCommand = new HandleCommand();
            DoSectionSelection();
            DoAlbumSelection();
        }

        public void DoSectionSelection()
        {
            Response sectionSelectionResponse;
            do
            {
                sectionSelectionResponse = _handleCommand.HandleSectionSelection(_sections);
                sectionSelectionResponse.WriteMessage();
            } while (!sectionSelectionResponse.IsSuccess);
        }

        public void DoAlbumSelection()
        {
            Response albumSelectionResponse;
            do
            {
                albumSelectionResponse = _handleCommand.HandleAlbumSelection();
                albumSelectionResponse.WriteMessage();
            } while (!albumSelectionResponse.IsSuccess);
            
        }
    }
}