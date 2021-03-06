﻿using System.Collections.Generic;
using System.Xml.Linq;
using NWebDav.Server;
using NWebDav.Server.Locking;
using NWebDav.Server.Stores;

namespace YaR.Clouds.WebDavStore.StoreBase
{
    public class EmptyLockingManager : ILockingManager
    {
        public LockResult Lock(IStoreItem item, LockType lockType, LockScope lockScope, XElement owner, WebDavUri lockRootUri,
            bool recursiveLock, IEnumerable<int> timeouts)
        {
            return LR;
        }
        static LockResult LR = new LockResult(DavStatusCode.Ok);

        public DavStatusCode Unlock(IStoreItem item, WebDavUri token)
        {
            return DavStatusCode.Ok;
        }

        public LockResult RefreshLock(IStoreItem item, bool recursiveLock, IEnumerable<int> timeouts, WebDavUri lockTokenUri)
        {
            return LR;
        }

        public IEnumerable<ActiveLock> GetActiveLockInfo(IStoreItem item)
        {
            yield break;
        }

        public IEnumerable<LockEntry> GetSupportedLocks(IStoreItem item)
        {
            yield break;
        }

        public bool IsLocked(IStoreItem item)
        {
            return false;
        }

        public bool HasLock(IStoreItem item, WebDavUri lockToken)
        {
            return false;
        }
    }
}