// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

using Eco.Client;
using Eco.Shared.View;
using EcoEngine.Subscription;
using UnityEngine;


public partial class SubscribableBehavior : TrackableBehavior, IMonoBehaviourSubscriptions
{
    Subscriptions IThreadUnsafeSubscriptions.Subscriptions { get; set; }
    bool       IMonoBehaviourSubscriptions.SubscriptionsReleased { get; set; }

    protected virtual void OnDestroy() => this.ReleaseSubscriptions();
}
