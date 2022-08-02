#include "StdAfx.h"
#include "LogItem.h"

using namespace System;

using namespace GoodbyeCaveira::Lib::Data;

System::String^ LogItem::ToString(){
	if (this->m_time)
	{
		if (type == null)
		{
			return text;
		}
		return System::String. $"[{type}] {text}";
	}
	else
	{
		if (type == null)
		{
			return $"[{time.ToString()}] {text}";
		}
		return $"[{time.ToString()} {type}] {text}";
	}
}

LogItem::LogItem(System::Nullable<System::DateTime>^ time, System::String^ type, System::String^ message)
{
	this->m_time=time;
	this->m_type=type;
	this->m_message=message;
}
