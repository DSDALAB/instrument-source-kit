<?xml version='1.0' encoding='UTF-8'?>
<Project Type="Project" LVVersion="17008000">
	<Item Name="My Computer" Type="My Computer">
		<Property Name="NI.SortType" Type="Int">3</Property>
		<Property Name="server.app.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.control.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.tcp.enabled" Type="Bool">false</Property>
		<Property Name="server.tcp.port" Type="Int">0</Property>
		<Property Name="server.tcp.serviceName" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.tcp.serviceName.default" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.vi.callsEnabled" Type="Bool">true</Property>
		<Property Name="server.vi.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="specify.custom.address" Type="Bool">false</Property>
		<Item Name="EXE" Type="Folder">
			<Item Name="PWRVT_Multi_thread.vi" Type="VI" URL="../PWRVT_Multi_thread.vi"/>
		</Item>
		<Item Name="Ctl" Type="Folder">
			<Item Name="ITRI.ctl" Type="VI" URL="../Ctl/ITRI.ctl"/>
			<Item Name="MEMS.ctl" Type="VI" URL="../Ctl/MEMS.ctl"/>
			<Item Name="Modbus function.ctl" Type="VI" URL="../Ctl/Modbus function.ctl"/>
			<Item Name="OA.ctl" Type="VI" URL="../Ctl/OA.ctl"/>
			<Item Name="ProcessDATA.ctl" Type="VI" URL="../Ctl/ProcessDATA.ctl"/>
		</Item>
		<Item Name="DLL" Type="Folder">
			<Item Name="LabVIEW_CSLib.dll" Type="Document" URL="../DLL/LabVIEW_CSLib.dll"/>
			<Item Name="log4net.dll" Type="Document" URL="../DLL/log4net.dll"/>
			<Item Name="Modbus.dll" Type="Document" URL="../DLL/Modbus.dll"/>
			<Item Name="Unme.Common.dll" Type="Document" URL="../DLL/Unme.Common.dll"/>
		</Item>
		<Item Name="RVT" Type="Folder">
			<Property Name="NI.SortType" Type="Int">3</Property>
			<Item Name="Caculator" Type="Folder">
				<Item Name="Caculator.ctl" Type="VI" URL="../ModbusRTU/Caculator/Caculator.ctl"/>
				<Item Name="Caculator.lvclass" Type="LVClass" URL="../ModbusRTU/Caculator/Caculator.lvclass"/>
			</Item>
			<Item Name="Process" Type="Folder">
				<Item Name="Process.ctl" Type="VI" URL="../ModbusRTU/Process/Process.ctl"/>
				<Item Name="Process.lvclass" Type="LVClass" URL="../ModbusRTU/Process/Process.lvclass"/>
			</Item>
			<Item Name="LNAX301" Type="Folder">
				<Item Name="LNAX301.lvclass" Type="LVClass" URL="../ModbusRTU/LNAX301/LNAX301.lvclass"/>
			</Item>
			<Item Name="ModbusRTUCmd.ctl" Type="VI" URL="../ModbusRTU/ModbusRTUCmd.ctl"/>
		</Item>
		<Item Name="SubVI" Type="Folder">
			<Item Name="Get Buffer Status.vi" Type="VI" URL="../SubVI/Get Buffer Status.vi"/>
			<Item Name="HPF.vi" Type="VI" URL="../SubVI/HPF.vi"/>
			<Item Name="OA Acc.vi" Type="VI" URL="../SubVI/OA Acc.vi"/>
			<Item Name="OA Vel.vi" Type="VI" URL="../SubVI/OA Vel.vi"/>
			<Item Name="Read Chip ID.vi" Type="VI" URL="../SubVI/Read Chip ID.vi"/>
			<Item Name="Read Data.vi" Type="VI" URL="../SubVI/Read Data.vi"/>
			<Item Name="RMS.vi" Type="VI" URL="../SubVI/RMS.vi"/>
			<Item Name="Sample rate change.vi" Type="VI" URL="../SubVI/Sample rate change.vi"/>
			<Item Name="Set Bulk Stream Size.vi" Type="VI" URL="../SubVI/Set Bulk Stream Size.vi"/>
			<Item Name="Temperature.vi" Type="VI" URL="../SubVI/Temperature.vi"/>
		</Item>
		<Item Name="ini.vi" Type="VI" URL="../ini.vi"/>
		<Item Name="Dependencies" Type="Dependencies">
			<Item Name="vi.lib" Type="Folder">
				<Item Name="Check for Equality.vi" Type="VI" URL="/&lt;vilib&gt;/Waveform/WDTOps.llb/Check for Equality.vi"/>
				<Item Name="Clear Errors.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Clear Errors.vi"/>
				<Item Name="DU64_U32SubtractWithBorrow.vi" Type="VI" URL="/&lt;vilib&gt;/Waveform/TSOps.llb/DU64_U32SubtractWithBorrow.vi"/>
				<Item Name="I128 Timestamp.ctl" Type="VI" URL="/&lt;vilib&gt;/Waveform/TSOps.llb/I128 Timestamp.ctl"/>
				<Item Name="NI_AALBase.lvlib" Type="Library" URL="/&lt;vilib&gt;/Analysis/NI_AALBase.lvlib"/>
				<Item Name="NI_AALPro.lvlib" Type="Library" URL="/&lt;vilib&gt;/Analysis/NI_AALPro.lvlib"/>
				<Item Name="NI_MABase.lvlib" Type="Library" URL="/&lt;vilib&gt;/measure/NI_MABase.lvlib"/>
				<Item Name="NI_MAPro.lvlib" Type="Library" URL="/&lt;vilib&gt;/measure/NI_MAPro.lvlib"/>
				<Item Name="Timestamp Subtract.vi" Type="VI" URL="/&lt;vilib&gt;/Waveform/TSOps.llb/Timestamp Subtract.vi"/>
				<Item Name="Modbus Master.lvclass" Type="LVClass" URL="/&lt;vilib&gt;/NI/Modbus Library/API/Master/Modbus Master.lvclass"/>
				<Item Name="Network Master.lvclass" Type="LVClass" URL="/&lt;vilib&gt;/NI/Modbus Library/Network Protocol/Network Master/Network Master.lvclass"/>
				<Item Name="Error Cluster From Error Code.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Cluster From Error Code.vi"/>
				<Item Name="Network Protocol.lvclass" Type="LVClass" URL="/&lt;vilib&gt;/NI/Modbus Library/Network Protocol/Network Protocol.lvclass"/>
				<Item Name="Master Function Definition.lvclass" Type="LVClass" URL="/&lt;vilib&gt;/NI/Modbus Library/Master Function Definition/Master Function Definition.lvclass"/>
				<Item Name="Device Data Model.lvclass" Type="LVClass" URL="/&lt;vilib&gt;/NI/Modbus Library/Data Model/Device Data Model.lvclass"/>
				<Item Name="Modbus Data Unit.lvclass" Type="LVClass" URL="/&lt;vilib&gt;/NI/Modbus Library/Modbus Data Unit/Modbus Data Unit.lvclass"/>
				<Item Name="Bits to Bytes.vi" Type="VI" URL="/&lt;vilib&gt;/NI/Modbus Library/Utility/Bits to Bytes.vi"/>
				<Item Name="U16s to Bytes.vi" Type="VI" URL="/&lt;vilib&gt;/NI/Modbus Library/Utility/U16s to Bytes.vi"/>
				<Item Name="Bytes to Bits.vi" Type="VI" URL="/&lt;vilib&gt;/NI/Modbus Library/Utility/Bytes to Bits.vi"/>
				<Item Name="Bytes to U16s.vi" Type="VI" URL="/&lt;vilib&gt;/NI/Modbus Library/Utility/Bytes to U16s.vi"/>
				<Item Name="Modbus API.lvclass" Type="LVClass" URL="/&lt;vilib&gt;/NI/Modbus Library/API/Modbus API.lvclass"/>
				<Item Name="Transmission Data Unit.lvclass" Type="LVClass" URL="/&lt;vilib&gt;/NI/Modbus Library/Transmission Data Unit/Transmission Data Unit.lvclass"/>
				<Item Name="Serial Data Unit.lvclass" Type="LVClass" URL="/&lt;vilib&gt;/NI/Modbus Library/Transmission Data Unit/Serial Interface/Serial Data Unit.lvclass"/>
				<Item Name="VISA Find Search Mode.ctl" Type="VI" URL="/&lt;vilib&gt;/Instr/_visa.llb/VISA Find Search Mode.ctl"/>
			</Item>
			<Item Name="lvanlys.dll" Type="Document" URL="/&lt;resource&gt;/lvanlys.dll"/>
			<Item Name="System" Type="VI" URL="System">
				<Property Name="NI.PreserveRelativePath" Type="Bool">true</Property>
			</Item>
			<Item Name="Check data length.vi" Type="VI" URL="../SubVI/Check data length.vi"/>
			<Item Name="Bulk Mode Read Data.vi" Type="VI" URL="../SubVI/Bulk Mode Read Data.vi"/>
			<Item Name="MultRead.vi" Type="VI" URL="../MultRead.vi"/>
		</Item>
		<Item Name="Build Specifications" Type="Build"/>
	</Item>
</Project>
