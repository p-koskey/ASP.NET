using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Web;
using Unity;

namespace RestaurantsServices
{
    public class UnityInstanceProvider : IInstanceProvider
    {
        #region Fields

        private readonly IUnityContainer _container;
        private readonly Type _serviceType;

        #endregion

        #region Constructor

        /// <summary>
        /// Create a new instance of unity instance provider
        /// </summary>
        /// <param name="serviceType"> The service where we apply the instance provider </param>
        public UnityInstanceProvider(Type serviceType)
        {
            if (serviceType == null)
                throw new ArgumentNullException("serviceType");

            _serviceType = serviceType;
            _container = Container.Current;
        }

        #endregion

        #region IInstanceProvider Members

        /// <summary>
        /// <see cref="System.ServiceModel.Dispatcher.IInstanceProvider" />
        /// </summary>
        /// <param name="instanceContext"> <see cref="System.ServiceModel.Dispatcher.IInstanceProvider" /> </param>
        /// <param name="message"> <see cref="System.ServiceModel.Dispatcher.IInstanceProvider" /> </param>
        /// <returns> <see cref="System.ServiceModel.Dispatcher.IInstanceProvider" /> </returns>
        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            //This is the only call to UNITY container in the whole solution
            return _container.Resolve(_serviceType);
        }

        /// <summary>
        /// <see cref="System.ServiceModel.Dispatcher.IInstanceProvider" />
        /// </summary>
        /// <param name="instanceContext"> <see cref="System.ServiceModel.Dispatcher.IInstanceProvider" /> </param>
        /// <returns> <see cref="System.ServiceModel.Dispatcher.IInstanceProvider" /> </returns>
        public object GetInstance(InstanceContext instanceContext)
        {
            return GetInstance(instanceContext, null);
        }

        /// <summary>
        /// <see cref="System.ServiceModel.Dispatcher.IInstanceProvider" />
        /// </summary>
        /// <param name="instanceContext"> <see cref="System.ServiceModel.Dispatcher.IInstanceProvider" /> </param>
        /// <param name="instance"> <see cref="System.ServiceModel.Dispatcher.IInstanceProvider" /> </param>
        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
            var disposable = instance as IDisposable;
            if (disposable != null)
                disposable.Dispose();
        }

        #endregion
    }
}