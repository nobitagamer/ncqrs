﻿using System;
using System.Collections.Generic;
using Ncqrs.Eventing.Sourcing;

namespace Ncqrs.EventBus
{    
    public interface IBrowsableEventStore
    {
        void SetCursorPositionAfter(Guid? lastEventId);
        IEnumerable<SourcedEvent> FetchEvents(int maxCount);
    }
}