namespace OpenArcServer.Core;

public enum DistroType
{
    ToNil,
    ToRequester,
    ToAll,
    ToUsers,
    ToNode,
    ToNodes,
    ToPcxxNodes,
    ToCall,
    ToCallPlusSsids,
    ToPubChatRoom,
    ToPvtChatRoom
}

public enum ConnectStateType
{
    TelnetUser,
    PcxxNode,
    PcxxUser,
    ArxNode,
    ArxClient,
    AgwBpqUser,
    RcvOnly,
    WebSocketUser
}

public enum ConnectionState
{
    Idle,
    CallsignRequest,
    CallsignValidation,
    Connected
}

public enum MsgType
{
    General,
    Dx,
    DxLocal,
    Ann,
    Wx,
    Wwv,
    Talk
}
