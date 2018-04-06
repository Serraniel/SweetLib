<a name='contents'></a>
# Contents [#](#contents 'Go To Here')

- [IStreamable](#T-SweetLib-IO-Classes-Streaming-IStreamable 'SweetLib.IO.Classes.Streaming.IStreamable')
  - [LoadFromStream(stream)](#M-SweetLib-IO-Classes-Streaming-IStreamable-LoadFromStream-System-IO-Stream- 'SweetLib.IO.Classes.Streaming.IStreamable.LoadFromStream(System.IO.Stream)')
  - [SaveToStream(stream)](#M-SweetLib-IO-Classes-Streaming-IStreamable-SaveToStream-System-IO-Stream- 'SweetLib.IO.Classes.Streaming.IStreamable.SaveToStream(System.IO.Stream)')
- [StreamException](#T-SweetLib-IO-Classes-Streaming-StreamException 'SweetLib.IO.Classes.Streaming.StreamException')
  - [#ctor()](#M-SweetLib-IO-Classes-Streaming-StreamException-#ctor 'SweetLib.IO.Classes.Streaming.StreamException.#ctor')
  - [#ctor(message)](#M-SweetLib-IO-Classes-Streaming-StreamException-#ctor-System-String- 'SweetLib.IO.Classes.Streaming.StreamException.#ctor(System.String)')
- [StreamManager](#T-SweetLib-IO-Classes-Streaming-StreamManager 'SweetLib.IO.Classes.Streaming.StreamManager')
  - [LoadFromStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-String@- 'SweetLib.IO.Classes.Streaming.StreamManager.LoadFromStream(System.IO.Stream,System.String@)')
  - [LoadFromStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Boolean@- 'SweetLib.IO.Classes.Streaming.StreamManager.LoadFromStream(System.IO.Stream,System.Boolean@)')
  - [LoadFromStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Char@- 'SweetLib.IO.Classes.Streaming.StreamManager.LoadFromStream(System.IO.Stream,System.Char@)')
  - [LoadFromStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Int32@- 'SweetLib.IO.Classes.Streaming.StreamManager.LoadFromStream(System.IO.Stream,System.Int32@)')
  - [LoadFromStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Int64@- 'SweetLib.IO.Classes.Streaming.StreamManager.LoadFromStream(System.IO.Stream,System.Int64@)')
  - [LoadFromStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Single@- 'SweetLib.IO.Classes.Streaming.StreamManager.LoadFromStream(System.IO.Stream,System.Single@)')
  - [LoadFromStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Double@- 'SweetLib.IO.Classes.Streaming.StreamManager.LoadFromStream(System.IO.Stream,System.Double@)')
  - [LoadFromStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-DateTime@- 'SweetLib.IO.Classes.Streaming.StreamManager.LoadFromStream(System.IO.Stream,System.DateTime@)')
  - [LoadFromStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-IO-Stream@- 'SweetLib.IO.Classes.Streaming.StreamManager.LoadFromStream(System.IO.Stream,System.IO.Stream@)')
  - [SaveToStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-String- 'SweetLib.IO.Classes.Streaming.StreamManager.SaveToStream(System.IO.Stream,System.String)')
  - [SaveToStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Boolean- 'SweetLib.IO.Classes.Streaming.StreamManager.SaveToStream(System.IO.Stream,System.Boolean)')
  - [SaveToStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Char- 'SweetLib.IO.Classes.Streaming.StreamManager.SaveToStream(System.IO.Stream,System.Char)')
  - [SaveToStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Int32- 'SweetLib.IO.Classes.Streaming.StreamManager.SaveToStream(System.IO.Stream,System.Int32)')
  - [SaveToStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Int64- 'SweetLib.IO.Classes.Streaming.StreamManager.SaveToStream(System.IO.Stream,System.Int64)')
  - [SaveToStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Single- 'SweetLib.IO.Classes.Streaming.StreamManager.SaveToStream(System.IO.Stream,System.Single)')
  - [SaveToStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Double- 'SweetLib.IO.Classes.Streaming.StreamManager.SaveToStream(System.IO.Stream,System.Double)')
  - [SaveToStream(stream,value)](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-DateTime- 'SweetLib.IO.Classes.Streaming.StreamManager.SaveToStream(System.IO.Stream,System.DateTime)')
  - [SaveToStream(stream,value,resetSourceStream)](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-IO-Stream,System-Boolean- 'SweetLib.IO.Classes.Streaming.StreamManager.SaveToStream(System.IO.Stream,System.IO.Stream,System.Boolean)')
- [StreamTypeException](#T-SweetLib-IO-Classes-Streaming-StreamTypeException 'SweetLib.IO.Classes.Streaming.StreamTypeException')
  - [#ctor()](#M-SweetLib-IO-Classes-Streaming-StreamTypeException-#ctor 'SweetLib.IO.Classes.Streaming.StreamTypeException.#ctor')
  - [#ctor(message)](#M-SweetLib-IO-Classes-Streaming-StreamTypeException-#ctor-System-String- 'SweetLib.IO.Classes.Streaming.StreamTypeException.#ctor(System.String)')

<a name='assembly'></a>
# SweetLib.IO [#](#assembly 'Go To Here') [=](#contents 'Back To Contents')

<a name='T-SweetLib-IO-Classes-Streaming-IStreamable'></a>
## IStreamable [#](#T-SweetLib-IO-Classes-Streaming-IStreamable 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

SweetLib.IO.Classes.Streaming

##### Summary

Streamable objects

<a name='M-SweetLib-IO-Classes-Streaming-IStreamable-LoadFromStream-System-IO-Stream-'></a>
### LoadFromStream(stream) `method` [#](#M-SweetLib-IO-Classes-Streaming-IStreamable-LoadFromStream-System-IO-Stream- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads the object from a given stream.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | Stream from which the object is loaded. |

<a name='M-SweetLib-IO-Classes-Streaming-IStreamable-SaveToStream-System-IO-Stream-'></a>
### SaveToStream(stream) `method` [#](#M-SweetLib-IO-Classes-Streaming-IStreamable-SaveToStream-System-IO-Stream- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Saves the current object into a stream.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | Stream in which the current object should be saved. |

<a name='T-SweetLib-IO-Classes-Streaming-StreamException'></a>
## StreamException [#](#T-SweetLib-IO-Classes-Streaming-StreamException 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

SweetLib.IO.Classes.Streaming

##### Summary

Exception thrown by streaming related operations.

<a name='M-SweetLib-IO-Classes-Streaming-StreamException-#ctor'></a>
### #ctor() `constructor` [#](#M-SweetLib-IO-Classes-Streaming-StreamException-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates a new [StreamException](#T-SweetLib-IO-Classes-Streaming-StreamException 'SweetLib.IO.Classes.Streaming.StreamException').

##### Parameters

This constructor has no parameters.

<a name='M-SweetLib-IO-Classes-Streaming-StreamException-#ctor-System-String-'></a>
### #ctor(message) `constructor` [#](#M-SweetLib-IO-Classes-Streaming-StreamException-#ctor-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates a new [StreamException](#T-SweetLib-IO-Classes-Streaming-StreamException 'SweetLib.IO.Classes.Streaming.StreamException').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Exception message. |

<a name='T-SweetLib-IO-Classes-Streaming-StreamManager'></a>
## StreamManager [#](#T-SweetLib-IO-Classes-Streaming-StreamManager 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

SweetLib.IO.Classes.Streaming

##### Summary

[StreamManager](#T-SweetLib-IO-Classes-Streaming-StreamManager 'SweetLib.IO.Classes.Streaming.StreamManager') wraps some useful methods for custom implementations of object streaming.

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-String@-'></a>
### LoadFromStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-String@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') from a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') from which the [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') will be loaded. |
| value | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') | Contains the loaded [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Boolean@-'></a>
### LoadFromStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Boolean@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') from a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') from which the [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') will be loaded. |
| value | [System.Boolean@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean@ 'System.Boolean@') | Contains the loaded [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Char@-'></a>
### LoadFromStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Char@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads a [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') from a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') from which the [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') will be loaded. |
| value | [System.Char@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char@ 'System.Char@') | Contains the loaded [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') value. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Int32@-'></a>
### LoadFromStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Int32@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads a [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') from a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') from which the [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') will be loaded. |
| value | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | Contains the loaded [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') value. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Int64@-'></a>
### LoadFromStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Int64@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads a [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') from a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') from which the [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') will be loaded. |
| value | [System.Int64@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64@ 'System.Int64@') | Contains the loaded [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') value. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Single@-'></a>
### LoadFromStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Single@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') from a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') from which the [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') will be loaded. |
| value | [System.Single@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single@ 'System.Single@') | Contains the loaded [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Double@-'></a>
### LoadFromStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-Double@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads a [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') from a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') from which the [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') will be loaded. |
| value | [System.Double@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double@ 'System.Double@') | Contains the loaded [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') value. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-DateTime@-'></a>
### LoadFromStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-DateTime@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') from a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') from which the [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') will be loaded. |
| value | [System.DateTime@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime@ 'System.DateTime@') | Contains the loaded [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-IO-Stream@-'></a>
### LoadFromStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-LoadFromStream-System-IO-Stream,System-IO-Stream@- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Loads a [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') from a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') from which the [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') will be loaded. |
| value | [System.IO.Stream@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream@ 'System.IO.Stream@') | Contains the loaded [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') value. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-String-'></a>
### SaveToStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') to which the [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') will be added. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value to add. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Boolean-'></a>
### SaveToStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds a [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') to a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') to which the [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') will be added. |
| value | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') value to add. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Char-'></a>
### SaveToStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Char- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds a [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') to a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') to which the [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') will be added. |
| value | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | [Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') value to add. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Int32-'></a>
### SaveToStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds a [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') to a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') to which the [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') will be added. |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') value to add. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Int64-'></a>
### SaveToStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Int64- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds a [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') to a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') to which the [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') will be added. |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | [Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') value to add. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Single-'></a>
### SaveToStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Single- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds a [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') to a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') to which the [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') will be added. |
| value | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | [Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') value to add. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Double-'></a>
### SaveToStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-Double- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds a [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') to a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') to which the [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') will be added. |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | [Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') value to add. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-DateTime-'></a>
### SaveToStream(stream,value) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds a [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') to a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') to which the [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') will be added. |
| value | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value to add. |

<a name='M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-IO-Stream,System-Boolean-'></a>
### SaveToStream(stream,value,resetSourceStream) `method` [#](#M-SweetLib-IO-Classes-Streaming-StreamManager-SaveToStream-System-IO-Stream,System-IO-Stream,System-Boolean- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Adds a [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') to a given [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') to which the [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') will be added. |
| value | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') value to add. |
| resetSourceStream | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, the full given [](#!-value 'value') will be copied, otherwhise the stream will be copied from current position until its end. |

<a name='T-SweetLib-IO-Classes-Streaming-StreamTypeException'></a>
## StreamTypeException [#](#T-SweetLib-IO-Classes-Streaming-StreamTypeException 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

SweetLib.IO.Classes.Streaming

##### Summary

Exception thrown by streaming related operations. May be thrown if the stream types do not match.

<a name='M-SweetLib-IO-Classes-Streaming-StreamTypeException-#ctor'></a>
### #ctor() `constructor` [#](#M-SweetLib-IO-Classes-Streaming-StreamTypeException-#ctor 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates a new [StreamTypeException](#T-SweetLib-IO-Classes-Streaming-StreamTypeException 'SweetLib.IO.Classes.Streaming.StreamTypeException').

##### Parameters

This constructor has no parameters.

<a name='M-SweetLib-IO-Classes-Streaming-StreamTypeException-#ctor-System-String-'></a>
### #ctor(message) `constructor` [#](#M-SweetLib-IO-Classes-Streaming-StreamTypeException-#ctor-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Creates a new [StreamTypeException](#T-SweetLib-IO-Classes-Streaming-StreamTypeException 'SweetLib.IO.Classes.Streaming.StreamTypeException').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Exception message. |
