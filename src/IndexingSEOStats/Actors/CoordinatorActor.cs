﻿using Akka.Actor;
using Akka.DI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndexingSEOStats.Actors
{
    public class CoordinatorActor : ReceiveActor
    {
        private IActorRef _requestSchedulerActor;
        public CoordinatorActor()
        {
            var propScheduler = Context.DI().Props<RequestSchedulerActor>();
            _requestSchedulerActor = Context.ActorOf(propScheduler, "RequestSchedulerActor");

            Receive<string>(m => HandleSchedule(m));
        }

        private void HandleSchedule(object message)
        {
            ActorSystemRefs.ActorSystem.Scheduler.ScheduleTellOnce
                   (TimeSpan.Zero, _requestSchedulerActor, "scheduleToday", ActorRefs.Nobody);

            ActorSystemRefs.ActorSystem.Scheduler.ScheduleTellRepeatedly
                   (TimeSpan.Zero, TimeSpan.FromHours(24), _requestSchedulerActor, "schedule", ActorRefs.Nobody);
        }
    }
}