﻿using UnityEngine;

namespace HT.Framework
{
    /// <summary>
    /// 实体逻辑基类
    /// </summary>
    public abstract class EntityLogic : IReference
    {
        /// <summary>
        /// 实体
        /// </summary>
        public GameObject Entity;

        /// <summary>
        /// 实体是否显示
        /// </summary>
        public bool IsShowed
        {
            get
            {
                return Entity.activeSelf;
            }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public virtual void OnInit()
        {
        }
        
        /// <summary>
        /// 显示实体
        /// </summary>
        public virtual void OnShow()
        {
        }

        /// <summary>
        /// 隐藏实体
        /// </summary>
        public virtual void OnHide()
        {
        }

        /// <summary>
        /// 销毁实体
        /// </summary>
        public virtual void OnDestroy()
        {
        }

        /// <summary>
        /// 实体逻辑刷新
        /// </summary>
        public virtual void OnUpdate()
        {
        }

        /// <summary>
        /// 重置实体
        /// </summary>
        public virtual void Reset()
        {
        }
    }
}