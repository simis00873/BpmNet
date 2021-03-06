﻿using System;
using System.Xml.Serialization;

namespace BpmNet.Bpmn
{
    [Serializable()]
    [XmlType(Namespace = "http://www.omg.org/spec/BPMN/20100524/DI")]
    public enum MessageVisibleKind
    {
        initiating,
        non_initiating,
    }
}
