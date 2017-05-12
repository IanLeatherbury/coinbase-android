using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Coinbase.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.coinbase.api']/class[@name='ObjectMapperProvider']"
	[global::Android.Runtime.Register ("com/coinbase/api/ObjectMapperProvider", DoNotGenerateAcw=true)]
	public partial class ObjectMapperProvider : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/coinbase/api/ObjectMapperProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectMapperProvider); }
		}

		protected ObjectMapperProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.coinbase.api']/class[@name='ObjectMapperProvider']/constructor[@name='ObjectMapperProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ObjectMapperProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ObjectMapperProvider)) {
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
