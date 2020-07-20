﻿using System;
using System.Collections.Generic;
using System.Text;
using HsNetWorkSGData;

namespace OpenNetLinkApp.Models.Data
{
    public class SGApprManageData : SGData
    {
        public SGApprManageData()
        {

        }
        
        ~SGApprManageData()
        {

        }
        public void Copy(SGData data)
        {
            m_DicTagData = new Dictionary<string, string>(data.m_DicTagData);
            m_DicRecordData = new List<Dictionary<int, string>>(data.m_DicRecordData);
        }
    }
}