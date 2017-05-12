using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.exception']/class[@name='UnauthorizedDeviceException']"
	[global::Android.Runtime.Register ("com/coinbase/api/exception/UnauthorizedDeviceException", DoNotGenerateAcw=true)]
	public partial class UnauthorizedDeviceException : global::Com.Coinbase.Api.Exception.CoinbaseException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/exception/UnauthorizedDeviceException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnauthorizedDeviceException); }
		}

		protected UnauthorizedDeviceException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.exception']/class[@name='UnauthorizedDeviceException']/constructor[@name='UnauthorizedDeviceException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnauthorizedDeviceException ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UnauthorizedDeviceException)) {
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

	}
}
