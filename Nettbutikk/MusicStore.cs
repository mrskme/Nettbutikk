﻿using System;
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
            Response sectionSelectionResponse;
            do
            {
                sectionSelectionResponse = _handleCommand.HandleSectionSelection(_sections);
                sectionSelectionResponse.WriteMessage();
            } while (!sectionSelectionResponse.IsSuccess);

            Response albumSelectionResponse = _handleCommand.HandleAlbumSelection();
            albumSelectionResponse.WriteMessage();
        }
    }
}