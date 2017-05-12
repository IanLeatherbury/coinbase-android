using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OrderNode']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/OrderNode", DoNotGenerateAcw=true)]
	public partial class OrderNode : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/OrderNode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OrderNode); }
		}

		protected OrderNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OrderNode']/constructor[@name='OrderNode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OrderNode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OrderNode)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getOrder;
#pragma warning disable 0169
		static Delegate GetGetOrderHandler ()
		{
			if (cb_getOrder == null)
				cb_getOrder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrder);
			return cb_getOrder;
		}

		static IntPtr n_GetOrder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.OrderNode __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OrderNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Order);
		}
#pragma warning restore 0169

		static Delegate cb_setOrder_Lcom_coinbase_api_entity_Order_;
#pragma warning disable 0169
		static Delegate GetSetOrder_Lcom_coinbase_api_entity_Order_Handler ()
		{
			if (cb_setOrder_Lcom_coinbase_api_entity_Order_ == null)
				cb_setOrder_Lcom_coinbase_api_entity_Order_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrder_Lcom_coinbase_api_entity_Order_);
			return cb_setOrder_Lcom_coinbase_api_entity_Order_;
		}

		static void n_SetOrder_Lcom_coinbase_api_entity_Order_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.OrderNode __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OrderNode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Coinbase.Api.Entity.Order p0 = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Order = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOrder;
		static IntPtr id_setOrder_Lcom_coinbase_api_entity_Order_;
		public virtual unsafe global::Com.Coinbase.Api.Entity.Order Order {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OrderNode']/method[@name='getOrder' and count(parameter)=0]"
			[Register ("getOrder", "()Lcom/coinbase/api/entity/Order;", "GetGetOrderHandler")]
			get {
				if (id_getOrder == IntPtr.Zero)
					id_getOrder = JNIEnv.GetMethodID (class_ref, "getOrder", "()Lcom/coinbase/api/entity/Order;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (JNIEnv.CallObjectMethod  (Handle, id_getOrder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.Order> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrder", "()Lcom/coinbase/api/entity/Order;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OrderNode']/method[@name='setOrder' and count(parameter)=1 and parameter[1][@type='com.coinbase.api.entity.Order']]"
			[Register ("setOrder", "(Lcom/coinbase/api/entity/Order;)V", "GetSetOrder_Lcom_coinbase_api_entity_Order_Handler")]
			set {
				if (id_setOrder_Lcom_coinbase_api_entity_Order_ == IntPtr.Zero)
					id_setOrder_Lcom_coinbase_api_entity_Order_ = JNIEnv.GetMethodID (class_ref, "setOrder", "(Lcom/coinbase/api/entity/Order;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOrder_Lcom_coinbase_api_entity_Order_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrder", "(Lcom/coinbase/api/entity/Order;)V"), __args);
				} finally {
				}
			}
		}

	}
}
