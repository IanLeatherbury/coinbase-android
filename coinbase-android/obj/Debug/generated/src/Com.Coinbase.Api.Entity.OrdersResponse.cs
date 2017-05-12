using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OrdersResponse']"
	[global::Android.Runtime.Register ("com/coinbase/api/entity/OrdersResponse", DoNotGenerateAcw=true)]
	public partial class OrdersResponse : global::Com.Coinbase.Api.Entity.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/entity/OrdersResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OrdersResponse); }
		}

		protected OrdersResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OrdersResponse']/constructor[@name='OrdersResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OrdersResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OrdersResponse)) {
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

		static Delegate cb_getOrders;
#pragma warning disable 0169
		static Delegate GetGetOrdersHandler ()
		{
			if (cb_getOrders == null)
				cb_getOrders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrders);
			return cb_getOrders;
		}

		static IntPtr n_GetOrders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Coinbase.Api.Entity.OrdersResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OrdersResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Order>.ToLocalJniHandle (__this.Orders);
		}
#pragma warning restore 0169

		static Delegate cb_setOrders_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetOrders_Ljava_util_List_Handler ()
		{
			if (cb_setOrders_Ljava_util_List_ == null)
				cb_setOrders_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrders_Ljava_util_List_);
			return cb_setOrders_Ljava_util_List_;
		}

		static void n_SetOrders_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Coinbase.Api.Entity.OrdersResponse __this = global::Java.Lang.Object.GetObject<global::Com.Coinbase.Api.Entity.OrdersResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Order>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Orders = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOrders;
		static IntPtr id_setOrders_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Coinbase.Api.Entity.Order> Orders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OrdersResponse']/method[@name='getOrders' and count(parameter)=0]"
			[Register ("getOrders", "()Ljava/util/List;", "GetGetOrdersHandler")]
			get {
				if (id_getOrders == IntPtr.Zero)
					id_getOrders = JNIEnv.GetMethodID (class_ref, "getOrders", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Order>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getOrders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Order>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrders", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.coinbase.api.entity']/class[@name='OrdersResponse']/method[@name='setOrders' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.coinbase.api.entity.Order&gt;']]"
			[Register ("setOrders", "(Ljava/util/List;)V", "GetSetOrders_Ljava_util_List_Handler")]
			set {
				if (id_setOrders_Ljava_util_List_ == IntPtr.Zero)
					id_setOrders_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setOrders", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Coinbase.Api.Entity.Order>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOrders_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrders", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
