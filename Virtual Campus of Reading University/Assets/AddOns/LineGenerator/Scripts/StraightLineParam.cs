using UnityEngine;



/* ////////////////////////////////

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


///////////////////////////////////////// */

public class StraightLineParam : MonoBehaviour, IGenLine {

	public LineRenderer line;


	[Range(0,250)]
	public int num = 10;

	public virtual void genLine(Vector3 start, Vector3 end) {
		line.SetVertexCount(num);

		for (int i = 0; i < num; i++) {

			Vector3 newPos = Vector3.Lerp(start, end,(float)i/num);// Mathf.Lerp(start.y, end.y,(float)i/num);

			line.SetPosition(i, newPos);
		}

		
	}
}