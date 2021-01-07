<?xml version='1.0'?>
<Project Type="Project" LVVersion="8008005">
   <Item Name="My Computer" Type="My Computer">
      <Property Name="CCSymbols" Type="Str">OS,Win;CPU,x86;</Property>
      <Property Name="server.app.propertiesEnabled" Type="Bool">true</Property>
      <Property Name="server.control.propertiesEnabled" Type="Bool">true</Property>
      <Property Name="server.tcp.enabled" Type="Bool">false</Property>
      <Property Name="server.tcp.port" Type="Int">0</Property>
      <Property Name="server.tcp.serviceName" Type="Str">My Computer/VI Server</Property>
      <Property Name="server.tcp.serviceName.default" Type="Str">My Computer/VI Server</Property>
      <Property Name="server.vi.callsEnabled" Type="Bool">true</Property>
      <Property Name="server.vi.propertiesEnabled" Type="Bool">true</Property>
      <Property Name="specify.custom.address" Type="Bool">false</Property>
      <Item Name="Public" Type="Folder"/>
      <Item Name="Gamoto.lvlib" Type="Library" URL="Gamoto.lvlib">
         <Item Name="ChartData.vi" Type="VI" URL="Public/ChartData.vi"/>
         <Item Name="Close.vi" Type="VI" URL="Public/Close.vi"/>
         <Item Name="Initialize.vi" Type="VI" URL="Public/Initialize.vi"/>
         <Item Name="Read_by_Name.vi" Type="VI" URL="Public/Read_by_Name.vi"/>
         <Item Name="ReadRegister.vi" Type="VI" URL="Public/ReadRegister.vi"/>
         <Item Name="VI Tree.vi" Type="VI" URL="Public/VI Tree.vi"/>
         <Item Name="Write_by_Name.vi" Type="VI" URL="Public/Write_by_Name.vi"/>
         <Item Name="WritePanel.vi" Type="VI" URL="Public/WritePanel.vi"/>
         <Item Name="WriteRegister.vi" Type="VI" URL="Public/WriteRegister.vi"/>
      </Item>
      <Item Name="Dependencies" Type="Dependencies"/>
      <Item Name="Build Specifications" Type="Build"/>
   </Item>
</Project>
