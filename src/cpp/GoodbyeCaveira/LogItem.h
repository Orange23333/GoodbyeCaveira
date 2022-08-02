#pragma once

using namespace System;

namespace GoodbyeCaveira{
	namespace Lib{
		namespace Data{
			ref class LogItem
			{
				protected: System::Nullable<System::DateTime>^ m_time;
				public: property System::Nullable<System::DateTime>^ Time{
					System::Nullable<System::DateTime>^ get();
					set(System::Nullable<System::DateTime>^ value);
				}
				protected: System::String^ m_type;
				public: property System::String^ MessageType{
					System::String^ get();
					set(System::String^ value);
				}
				protected: System::String^ m_message;
				public: property System::String^ Message{
					System::String^ get();
					set(System::String^ value);
				}
				
				public: override System::String^ ToString()
				
				public: LogItem(System::Nullable<System::DateTime>^ time, System::String^ type, System::String^ message);
			};
		}
	}
}
