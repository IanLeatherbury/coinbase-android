using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api.exception']/class[@name='UnspecifiedAccount']"
	[global::Android.Runtime.Register ("com/coinbase/api/exception/UnspecifiedAccount", DoNotGenerateAcw=true)]
	public partial class UnspecifiedAccount : global::Com.Coinbase.Api.Exception.CoinbaseException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/exception/UnspecifiedAccount", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnspecifiedAccount); }
		}

		protected UnspecifiedAccount (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api.exception']/class[@name='UnspecifiedAccount']/constructor[@name='UnspecifiedAccount' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnspecifiedAccount ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UnspecifiedAccount)) {
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
