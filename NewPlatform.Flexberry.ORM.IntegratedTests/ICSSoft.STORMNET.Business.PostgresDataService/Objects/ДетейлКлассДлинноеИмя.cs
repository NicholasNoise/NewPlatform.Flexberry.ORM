﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.TestClassesForPostgres
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// ДетейлКлассДлинноеИмя.
    /// </summary>
    // *** Start programmer edit section *** (ДетейлКлассДлинноеИмя CustomAttributes)

    // *** End programmer edit section *** (ДетейлКлассДлинноеИмя CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class ДетейлКлассДлинноеИмя : IIS.TestClassesForPostgres.DetailClass
    {
        
        private IIS.TestClassesForPostgres.ДочернийКлассДлинноеИмя fДочернийКлассДлинноеИмя;
        
        // *** Start programmer edit section *** (ДетейлКлассДлинноеИмя CustomMembers)

        // *** End programmer edit section *** (ДетейлКлассДлинноеИмя CustomMembers)

        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.TestClassesForPostgres.ДочернийКлассДлинноеИмя.
        /// </summary>
        // *** Start programmer edit section *** (ДетейлКлассДлинноеИмя.ДочернийКлассДлинноеИмя CustomAttributes)

        // *** End programmer edit section *** (ДетейлКлассДлинноеИмя.ДочернийКлассДлинноеИмя CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage("ДочернийКлассДлинноеИмя")]
        [TypeUsage(new string[] {
                "IIS.TestClassesForPostgres.ДочернийКлассДлинноеИмя",
                "IIS.TestClassesForPostgres.ДочернийКлассДлинноеИмя2"})]
        public virtual IIS.TestClassesForPostgres.ДочернийКлассДлинноеИмя ДочернийКлассДлинноеИмя
        {
            get
            {
                // *** Start programmer edit section *** (ДетейлКлассДлинноеИмя.ДочернийКлассДлинноеИмя Get start)

                // *** End programmer edit section *** (ДетейлКлассДлинноеИмя.ДочернийКлассДлинноеИмя Get start)
                IIS.TestClassesForPostgres.ДочернийКлассДлинноеИмя result = this.fДочернийКлассДлинноеИмя;
                // *** Start programmer edit section *** (ДетейлКлассДлинноеИмя.ДочернийКлассДлинноеИмя Get end)

                // *** End programmer edit section *** (ДетейлКлассДлинноеИмя.ДочернийКлассДлинноеИмя Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДетейлКлассДлинноеИмя.ДочернийКлассДлинноеИмя Set start)

                // *** End programmer edit section *** (ДетейлКлассДлинноеИмя.ДочернийКлассДлинноеИмя Set start)
                this.fДочернийКлассДлинноеИмя = value;
                // *** Start programmer edit section *** (ДетейлКлассДлинноеИмя.ДочернийКлассДлинноеИмя Set end)

                // *** End programmer edit section *** (ДетейлКлассДлинноеИмя.ДочернийКлассДлинноеИмя Set end)
            }
        }
    }
    
    /// <summary>
    /// Detail array of ДетейлКлассДлинноеИмя.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfДетейлКлассДлинноеИмя CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfДетейлКлассДлинноеИмя CustomAttributes)
    public class DetailArrayOfДетейлКлассДлинноеИмя : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.TestClassesForPostgres.DetailArrayOfДетейлКлассДлинноеИмя members)

        // *** End programmer edit section *** (IIS.TestClassesForPostgres.DetailArrayOfДетейлКлассДлинноеИмя members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ДетейлКлассДлинноеИмя by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ДетейлКлассДлинноеИмя.
        /// </summary>
        public DetailArrayOfДетейлКлассДлинноеИмя(IIS.TestClassesForPostgres.ДочернийКлассДлинноеИмя fДочернийКлассДлинноеИмя) : 
                base(typeof(ДетейлКлассДлинноеИмя), ((ICSSoft.STORMNET.DataObject)(fДочернийКлассДлинноеИмя)))
        {
        }
        
        public IIS.TestClassesForPostgres.ДетейлКлассДлинноеИмя this[int index]
        {
            get
            {
                return ((IIS.TestClassesForPostgres.ДетейлКлассДлинноеИмя)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.TestClassesForPostgres.ДетейлКлассДлинноеИмя dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
