﻿using System;
using ReactGraph.Internals.NodeInfo;

namespace ReactGraph.Internals.Construction
{
    abstract class DependencyDescriptor<T> : DependencyDescriptor
    {
        public abstract IWritableNodeInfo<T> GetOrCreateWritableNodeInfo(NodeRepository repo);
    }
}